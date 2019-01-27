Public Class HangulVB

    Public Function VERSION() As Version
        Return My.Application.Info.Version

    End Function

    Public Enum charState
        Etc = 1000 ' 기타
        JaEum = 10 ' 한글 자음
        MoEum = 20 ' 한글 모음
        Emjol = 30 ' 음절
        English = 40 ' 영어

        Control = 10001 ' 컴퓨터 컨트롤 키 코드
        Number = 10002 ' 숫자
        ASCII_Special_Char = 10003 ' ASCII 특수문자
        OldHangul = 10004 ' 옛 한글

        Front = 100 ' 초성
        Tail = 101 ' 종성
        Middle = 200 ' 중성

        HanEmjol = 300 ' 한글 음절

        UpperEnglish = 400 ' 영어 [대문자]
        LowerEnglish = 401 ' 영어 [소문자]

    End Enum

    Public Enum StringOption
        NULL = &B1 ' 아무 효과 적용안함, 글만 전달. 모든 옵션에 우선함
        WithType = &B10 ' 타입 추가
        WithInteger = &B100 ' 글자 코드 추가
        ReplaceToInt = &B1000 ' 글자 대신 글자 코드 추가 [WithInteger]보다 우선함

    End Enum

    Public Structure charData
        Public value As Integer

        Public Function GetChar() As Char
            Return ChrW(value)
        End Function

        Public Sub SetChar(ByVal chr As Char)
            value = AscW(chr)

        End Sub
        Public Sub SetChar(ByVal str As String)
            SetChar(CChar(Mid(str, 1, 1)))

        End Sub ' 문자열을 넘길 경우 처음 한글자에 해당하는 값을 저장

        Public Function Type() As charState
            Select Case value
                Case &H0 To &H1F
                    Return charState.Control
                Case &H7F
                    Return charState.Control

                Case &H20 To &H2F
                    Return charState.ASCII_Special_Char
                Case &H3A To &H40
                    Return charState.ASCII_Special_Char
                Case &H5B To &H60
                    Return charState.ASCII_Special_Char
                Case &H7B To &H7E
                    Return charState.ASCII_Special_Char


                Case &H30 To &H39
                    Return charState.Number

                Case &H41 To &H5A
                    Return charState.UpperEnglish

                Case &H61 To &H7A
                    Return charState.LowerEnglish


                Case &H1100 To &H1113
                    Return charState.Front

                Case &H1161 To &H1176
                    Return charState.Middle

                Case &H11A7 To &H11C2 ' 0x11A7 = 종성 없음
                    Return charState.Tail


                Case &H3131 To &H314E
                    Return charState.JaEum

                Case &H314F To &H3170
                    Return charState.MoEum


                Case &H3171 To &H318E
                    Return charState.OldHangul


                Case &HAC00 To &HD7AF
                    Return charState.HanEmjol

                Case Else
                    Return charState.Etc

            End Select
        End Function

        Public Function BigType() As charState
            Return Type() / 10
        End Function

        Friend Sub Initialize()
            Me.value = Nothing

        End Sub

    End Structure

#Region "Create Struct"

    Public Function CreateStruct(ByVal str As String) As List(Of charData)
        Dim arr(str.Length - 1) As Integer

        For i = 1 To str.Length
            arr(i - 1) = AscW(Mid(str, i, 1))
        Next

        Return CreateStruct(arr)

    End Function ' String

    Public Function CreateStruct(ByVal chr As Char) As charData
        Return CreateStruct(AscW(chr))
    End Function ' Single Character

    Public Function CreateStruct(ByVal val() As Integer) As List(Of charData)
        Dim ls As New List(Of charData)
        For i = 0 To val.Count - 1
            ls.Add(CreateStruct(val(i)))
        Next

        Return ls

    End Function ' Multi Integer

    Public Function CreateStruct(ByVal valList As List(Of Integer)) As List(Of charData)
        Dim ls As New List(Of charData)
        For i = 0 To valList.Count - 1
            ls.Add(CreateStruct(valList(i)))
        Next
        Return ls
    End Function ' List Integer

    Public Function CreateStruct(ByVal val As Integer) As charData
        Return New charData With {.value = val}
    End Function ' Single Integer

#End Region

    Public Function StructToStr(ByVal target As List(Of charData), Optional ByVal OptType As StringOption = StringOption.NULL) As String


        Dim temp As String = Nothing
        Dim temp2 As String = Nothing
        Dim maxLength = target.Count - 1
        If (OptType And StringOption.NULL) Then
            temp = Nothing
            For i = 0 To maxLength
                temp &= target(i).GetChar()

            Next
        Else
            temp = "{ "

            If (OptType And StringOption.WithType) Then ' 타입 추가 기입
                For i = 0 To maxLength
                    If OptType And StringOption.ReplaceToInt Then
                        temp2 = target(i).value
                    Else
                        temp2 = target(i).GetChar()
                        If OptType And StringOption.WithInteger Then
                            temp2 &= $", {target(i).value}"
                        End If
                    End If
                    If Not (i = maxLength) Then REM 현재 index와 마지막이 같지 않을 때까지
                        temp &= "{ " & $"{temp2}, {target(i).Type()} " & "}, "
                    Else
                        temp &= "{ " & $"{temp2}, {target(i).Type()} " & "} "
                    End If
                Next


            Else ' 타입 추가 기입 X
                For i = 0 To maxLength
                    If OptType And StringOption.ReplaceToInt Then
                        temp2 = target(i).value
                    Else
                        temp2 = target(i).GetChar()
                        If OptType And StringOption.WithInteger Then
                            temp2 = "{" & temp2 & $", {target(i).value}" & "}"
                        End If
                    End If
                    If Not (i = maxLength) Then REM 현재 index와 마지막이 같지 않을 때까지

                        temp &= $"{temp2}, "
                    Else
                        temp &= $"{temp2} "
                    End If
                Next

            End If

            temp &= "}"
        End If
        Return temp

    End Function

#Region "FUNCTION"

    Public Function Combine(ByVal target As List(Of charData)) As List(Of charData)
        Dim ret As New List(Of charData)
        Dim maxCount As Integer = target.Count - 1
        Dim temp(1) As charData
        Dim Last As charState = Nothing
        '// 라이브러리를 쉽게 이용할 수 있도록 리스트를 보내면 알아서 검색해서 보냄

        For i = 0 To maxCount

            Select Case target(i).Type
                Case charState.Front
                Case charState.Middle
                    If Not (i + 1 <= maxCount AndAlso target(i + 1).Type = charState.Tail) Then
                        ret.Add(Combine(target(i - 1), target(i)))
                    End If
                Case charState.Tail
                    ret.Add(Combine(target(i - 2), target(i - 1), target(i)))
                Case Else
                    ret.Add(target(i))
            End Select


        Next

        Return ret
    End Function

    Public Function Combine(ByVal first As charData, ByVal middle As charData, Optional ByVal tail As charData = Nothing) As charData
        Dim result As charData = Nothing
        If tail.value = 0 Then
            tail = New charData With {.value = &H11A7}
        End If

#Region "예외처리"
        If Not (first.Type = charState.Front) Then
            result.value = -1
            Return result
        End If

        If Not (middle.Type = charState.Middle) Then
            result.value = -2
            Return result
        End If

        If Not (tail.Type = charState.Tail) Then
            result.value = -3
            Return result
        End If
#End Region

        first.value -= &H1100
        middle.value -= &H1161
        tail.value -= &H11A7

        result.value = (((first.value * 21) + middle.value) * 28) + tail.value + &HAC00

        Return result
    End Function


    Public Function Separate(ByVal dList As List(Of charData)) As List(Of charData)
        Dim ls As New List(Of charData)

        For i = 0 To dList.Count - 1
            ls.AddRange(Separate(dList(i)))
        Next

        Return ls
    End Function ' Structure Separate

    Public Function Separate(ByVal str As String) As List(Of charData)
        Dim ls As New List(Of charData)

        For i = 1 To str.Length
            ls.AddRange(Separate(CChar(Mid(str, i, 1))))
        Next

        Return ls
    End Function ' String Separate

    Public Function Separate(ByVal chr As Char) As List(Of charData)
        Return Separate(New charData With {.value = AscW(chr)})
    End Function ' Character Separate

    Public Function Separate(ByVal chr As charData) As List(Of charData)
        Dim ls As New List(Of charData)
        Dim temp As Integer = Nothing

#Region "예외처리"
        If Not (chr.Type = charState.HanEmjol) Then
            ls.Add(chr)
            Return ls
        End If ' 한글 음절이 아닌경우 받은 값을 그대로 전달

#End Region
        chr.value -= &HAC00


        temp = chr.value Mod 28
        chr.value -= temp
        chr.value /= 28
        If temp Then
            temp += &H11A7
            ls.Insert(0, New charData With {.value = temp}) ' 종성
        End If


        temp = chr.value Mod 21
        chr.value -= temp
        chr.value /= 21
        temp += &H1161
        ls.Insert(0, New charData With {.value = temp}) ' 중성


        temp = chr.value
        temp += &H1100
        ls.Insert(0, New charData With {.value = temp}) ' 초성

        Return ls
    End Function ' Base function

    Public Function IsHangul(ByVal src As String) As Boolean
        Return IsHangul(CreateStruct(src))
    End Function

    Public Function IsHangul(ByVal srcData As List(Of charData)) As Boolean
        For i = 0 To srcData.Count - 1
            Select Case srcData(i).Type
                Case charState.HanEmjol, charState.JaEum, charState.MoEum, charState.HanEmjol,
                     charState.Front, charState.Middle, charState.Tail
                    Return True
            End Select
        Next
        Return False
    End Function

#End Region





End Class
