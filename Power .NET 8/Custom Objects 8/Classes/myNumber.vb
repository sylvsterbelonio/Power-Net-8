Namespace myNumber

    Namespace Share

        ''' <summary>
        ''' This class will convert the number
        ''' </summary>
        ''' <remarks></remarks>
        Public Class Converter

            Shared US(1003) As String 'United States number naming system
            Shared SNu(20) As String 'Small number units
            Shared SNt(10) As String 'Small number tems
            Shared IsInitialized As Boolean
            Shared NonNumeric() As Char = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}

            Private Shared Function get_ReturnWords(ByVal Number As String, Optional ByVal GroupToWords As Boolean = True, Optional ByVal LimitGroups As Int32 = 0) As String
                'The sub 'Initialize' contains all of the name data
                'if it has already been called don't do it again.

                If IsInitialized = False Then
                    Initialize()
                End If

                'If the input exceeds 999+ millillion then exit
                If Number.Length > 3006 Then
                    Return "Number is too long."
                End If

                Dim GroupName As String = ""
                Dim OutPut As String = ""

                'Pad the left side of the number so that it is always a multiply of three digits long
                If Number.Length Mod 3 <> 0 Then
                    Number = Number.PadLeft(Number.Length + (3 - (Number.Length Mod 3)), "0")
                End If

                Dim Array(Number.Length \ 3) As String          'Load an array with digit groups
                Dim Element As Int16 = -1                       'Counter for the array elements
                Dim DisplayCount As Int32 = -1                  'Counts the number of groups displayed
                Dim LimitGroupsShowAll As Boolean = False       'Used when LimitGroups is 0 so that all are displayed

                'Load up an array with the digit grouping
                For Count As Int16 = 0 To Number.Length - 3 Step 3
                    Element += 1
                    Array(Element) = Number.Substring(Count, 3)
                    'If a non-number character of found then exit.
                    If IsNumeric(Array(Element)) = False Then
                        Return "Non-numeric character found."
                    End If
                Next

                'If LimitGroups = 0 then give an 'or' option so that all groups are displayed
                If LimitGroups = 0 Then
                    LimitGroupsShowAll = True
                End If

                'Loop through the array and produce output
                For Count As Int16 = 0 To (Number.Length \ 3) - 1
                    DisplayCount += 1
                    If DisplayCount < LimitGroups Or LimitGroupsShowAll Then
                        If Array(Count) = "000" Then Continue For
                        GroupName = US(((Number.Length \ 3) - 1) - Count + 1)
                        If GroupToWords = True Then
                            OutPut &= Group(Array(Count)).TrimEnd(" ") & " " & GroupName & " "
                        Else
                            OutPut &= Array(Count).TrimStart("0") & " " & GroupName & " "
                        End If
                    End If
                Next

                Array = Nothing

                Return OutPut
            End Function

            Private Shared Function Group(ByVal Argument As String) As String

                'This private function only returns names of numbers between 0 and 999
                'It is for use by NameOfNumber which will group the number in sets of 
                'three digits.

                Dim Hyphen As String = ""
                Dim OutPut As String = ""

                Dim d1 As Int16 = Val(Argument.Substring(0, 1)) 'Digit 1 (First number)
                Dim d2 As Int16 = Val(Argument.Substring(1, 1)) 'Digit 2 (Second number)
                Dim d3 As Int16 = Val(Argument.Substring(2, 1)) 'Digit 3 (Third number)

                'What to say when first digit is 1 to 9
                If d1 >= 1 Then
                    OutPut &= SNu(d1) & " Hundred "
                End If

                'What to say when second and third digit is between 0 and 19
                If Val(Argument.Substring(1, 2)) < 20 Then
                    OutPut &= SNu(Val(Argument.Substring(1, 2)))
                End If

                'What to say when second and third digit is between 20 and 99
                If Val(Argument.Substring(1, 2)) >= 20 Then

                    'Add the hypen between the second and third word only when last digit is not 0
                    If Val(Argument.Substring(2, 1)) = 0 Then
                        Hyphen &= ""
                    Else
                        Hyphen &= "-"
                    End If

                    OutPut &= SNt(d2) & Hyphen & SNu(d3)

                End If

                Return OutPut

            End Function

            Private Shared Sub Initialize()

                IsInitialized = True

                'Names of units group
                SNu(0) = ""
                SNu(1) = "One"
                SNu(2) = "Two"
                SNu(3) = "Three"
                SNu(4) = "Four"
                SNu(5) = "Five"
                SNu(6) = "Six"
                SNu(7) = "Seven"
                SNu(8) = "Eight"
                SNu(9) = "Nine"
                SNu(10) = "Ten"
                SNu(11) = "Eleven"
                SNu(12) = "Twelve"
                SNu(13) = "Thirteen"
                SNu(14) = "Fourteen"
                SNu(15) = "Fifteen"
                SNu(16) = "Sixteen"
                SNu(17) = "Seventeen"
                SNu(18) = "Eighteen"
                SNu(19) = "Nineteen"

                'Names of tens group
                SNt(2) = "Twenty"
                SNt(3) = "Thirty"
                SNt(4) = "Forty"
                SNt(5) = "Fifty"
                SNt(6) = "Sixty"
                SNt(7) = "Seventy"
                SNt(8) = "Eighty"
                SNt(9) = "Ninety"

                'United States number naming system
                US(1) = ""
                US(2) = "Thousand"
                US(3) = "Million"
                US(4) = "Billion"
                US(5) = "Trillion"
                US(6) = "Quadrillion"
                US(7) = "Quintillion"
                US(8) = "sextillion"
                US(9) = "septillion"
                US(10) = "octillion"
                US(11) = "nonillion"
                US(12) = "decillion"
                US(13) = "undecillion"
                US(14) = "duodecillion"
                US(15) = "tredecillion"
                US(16) = "quattuordecillion"
                US(17) = "quinquadecillion"
                US(18) = "sedecillion"
                US(19) = "septendecillion"
                US(20) = "octodecillion"
                US(21) = "novendecillion"
                US(22) = "vigintillion"
                US(23) = "unvigintillion"
                US(24) = "duovigintillion"
                US(25) = "tresvigintillion"
                US(26) = "quattuorvigintillion"
                US(27) = "quinquavigintillion"
                US(28) = "sesvigintillion"
                US(29) = "septemvigintillion"
                US(30) = "octovigintillion"
                US(31) = "novemvigintillion"
                US(32) = "trigintillion"
                US(33) = "untrigintillion"
                US(34) = "duotrigintillion"
                US(35) = "trestrigintillion"
                US(36) = "quattuortrigintillion"
                US(37) = "quinquatrigintillion"
                US(38) = "sestrigintillion"
                US(39) = "septentrigintillion"
                US(40) = "octotrigintillion"
                US(41) = "noventrigintillion"
                US(42) = "quadragintillion"
                US(43) = "unquadragintillion"
                US(44) = "duoquadragintillion"
                US(45) = "tresquadragintillion"
                US(46) = "quattuorquadragintillion"
                US(47) = "quinquaquadragintillion"
                US(48) = "sesquadragintillion"
                US(49) = "septenquadragintillion"
                US(50) = "octoquadragintillion"
                US(51) = "novenquadragintillion"
                US(52) = "quinquagintillion"
                US(53) = "unquinquagintillion"
                US(54) = "duoquinquagintillion"
                US(55) = "tresquinquagintillion"
                US(56) = "quattuorquinquagintillion"
                US(57) = "quinquaquinquagintillion"
                US(58) = "sesquinquagintillion"
                US(59) = "septenquinquagintillion"
                US(60) = "octoquinquagintillion"
                US(61) = "novenquinquagintillion"
                US(62) = "sexagintillion"
                US(63) = "unsexagintillion"
                US(64) = "duosexagintillion"
                US(65) = "tresexagintillion"
                US(66) = "quattuorsexagintillion"
                US(67) = "quinquasexagintillion"
                US(68) = "sesexagintillion"
                US(69) = "septensexagintillion"
                US(70) = "octosexagintillion"
                US(71) = "novensexagintillion"
                US(72) = "septuagintillion"
                US(73) = "unseptuagintillion"
                US(74) = "duoseptuagintillion"
                US(75) = "treseptuagintillion"
                US(76) = "quattuorseptuagintillion"
                US(77) = "quinquaseptuagintillion"
                US(78) = "seseptuagintillion"
                US(79) = "septenseptuagintillion"
                US(80) = "octoseptuagintillion"
                US(81) = "novenseptuagintillion"
                US(82) = "octogintillion"
                US(83) = "unoctogintillion"
                US(84) = "duooctogintillion"
                US(85) = "tresoctogintillion"
                US(86) = "quattuoroctogintillion"
                US(87) = "quinquaoctogintillion"
                US(88) = "sexoctogintillion"
                US(89) = "septemoctogintillion"
                US(90) = "octooctogintillion"
                US(91) = "novemoctogintillion"
                US(92) = "nonagintillion"
                US(93) = "unnonagintillion"
                US(94) = "duononagintillion"
                US(95) = "trenonagintillion"
                US(96) = "quattuornonagintillion"
                US(97) = "quinquanonagintillion"
                US(98) = "senonagintillion"
                US(99) = "septenonagintillion"
                US(100) = "octononagintillion"
                US(101) = "novenonagintillion"
                US(102) = "centillion"
                US(103) = "uncentillion"
                US(104) = "duocentillion"
                US(105) = "trescentillion"
                US(106) = "quattuorcentillion"
                US(107) = "quinquacentillion"
                US(108) = "sexcentillion"
                US(109) = "septencentillion"
                US(110) = "octocentillion"
                US(111) = "novencentillion"
                US(112) = "decicentillion"
                US(113) = "undecicentillion"
                US(114) = "duodecicentillion"
                US(115) = "tredecicentillion"
                US(116) = "quattuordecicentillion"
                US(117) = "quinquadecicentillion"
                US(118) = "sedecicentillion"
                US(119) = "septendecicentillion"
                US(120) = "octodecicentillion"
                US(121) = "novendecicentillion"
                US(122) = "viginticentillion"
                US(123) = "unviginticentillion"
                US(124) = "duoviginticentillion"
                US(125) = "tresviginticentillion"
                US(126) = "quattuorviginticentillion"
                US(127) = "quinquaviginticentillion"
                US(128) = "sesviginticentillion"
                US(129) = "septemviginticentillion"
                US(130) = "octoviginticentillion"
                US(131) = "novemviginticentillion"
                US(132) = "trigintacentillion"
                US(133) = "untrigintacentillion"
                US(134) = "duotrigintacentillion"
                US(135) = "trestrigintacentillion"
                US(136) = "quattuortrigintacentillion"
                US(137) = "quinquatrigintacentillion"
                US(138) = "sestrigintacentillion"
                US(139) = "septentrigintacentillion"
                US(140) = "octotrigintacentillion"
                US(141) = "noventrigintacentillion"
                US(142) = "quadragintacentillion"
                US(143) = "unquadragintacentillion"
                US(144) = "duoquadragintacentillion"
                US(145) = "tresquadragintacentillion"
                US(146) = "quattuorquadragintacentillion"
                US(147) = "quinquaquadragintacentillion"
                US(148) = "sesquadragintacentillion"
                US(149) = "septenquadragintacentillion"
                US(150) = "octoquadragintacentillion"
                US(151) = "novenquadragintacentillion"
                US(152) = "quinquagintacentillion"
                US(153) = "unquinquagintacentillion"
                US(154) = "duoquinquagintacentillion"
                US(155) = "tresquinquagintacentillion"
                US(156) = "quattuorquinquagintacentillion"
                US(157) = "quinquaquinquagintacentillion"
                US(158) = "sesquinquagintacentillion"
                US(159) = "septenquinquagintacentillion"
                US(160) = "octoquinquagintacentillion"
                US(161) = "novenquinquagintacentillion"
                US(162) = "sexagintacentillion"
                US(163) = "unsexagintacentillion"
                US(164) = "duosexagintacentillion"
                US(165) = "tresexagintacentillion"
                US(166) = "quattuorsexagintacentillion"
                US(167) = "quinquasexagintacentillion"
                US(168) = "sesexagintacentillion"
                US(169) = "septensexagintacentillion"
                US(170) = "octosexagintacentillion"
                US(171) = "novensexagintacentillion"
                US(172) = "septuagintacentillion"
                US(173) = "unseptuagintacentillion"
                US(174) = "duoseptuagintacentillion"
                US(175) = "treseptuagintacentillion"
                US(176) = "quattuorseptuagintacentillion"
                US(177) = "quinquaseptuagintacentillion"
                US(178) = "seseptuagintacentillion"
                US(179) = "septenseptuagintacentillion"
                US(180) = "octoseptuagintacentillion"
                US(181) = "novenseptuagintacentillion"
                US(182) = "octogintacentillion"
                US(183) = "unoctogintacentillion"
                US(184) = "duooctogintacentillion"
                US(185) = "tresoctogintacentillion"
                US(186) = "quattuoroctogintacentillion"
                US(187) = "quinquaoctogintacentillion"
                US(188) = "sexoctogintacentillion"
                US(189) = "septemoctogintacentillion"
                US(190) = "octooctogintacentillion"
                US(191) = "novemoctogintacentillion"
                US(192) = "nonagintacentillion"
                US(193) = "unnonagintacentillion"
                US(194) = "duononagintacentillion"
                US(195) = "trenonagintacentillion"
                US(196) = "quattuornonagintacentillion"
                US(197) = "quinquanonagintacentillion"
                US(198) = "senonagintacentillion"
                US(199) = "septenonagintacentillion"
                US(200) = "octononagintacentillion"
                US(201) = "novenonagintacentillion"
                US(202) = "ducentillion"
                US(203) = "unducentillion"
                US(204) = "duoducentillion"
                US(205) = "treducentillion"
                US(206) = "quattuorducentillion"
                US(207) = "quinquaducentillion"
                US(208) = "seducentillion"
                US(209) = "septenducentillion"
                US(210) = "octoducentillion"
                US(211) = "novenducentillion"
                US(212) = "deciducentillion"
                US(213) = "undeciducentillion"
                US(214) = "duodeciducentillion"
                US(215) = "tredeciducentillion"
                US(216) = "quattuordeciducentillion"
                US(217) = "quinquadeciducentillion"
                US(218) = "sedeciducentillion"
                US(219) = "septendeciducentillion"
                US(220) = "octodeciducentillion"
                US(221) = "novendeciducentillion"
                US(222) = "vigintiducentillion"
                US(223) = "unvigintiducentillion"
                US(224) = "duovigintiducentillion"
                US(225) = "tresvigintiducentillion"
                US(226) = "quattuorvigintiducentillion"
                US(227) = "quinquavigintiducentillion"
                US(228) = "sesvigintiducentillion"
                US(229) = "septemvigintiducentillion"
                US(230) = "octovigintiducentillion"
                US(231) = "novemvigintiducentillion"
                US(232) = "trigintaducentillion"
                US(233) = "untrigintaducentillion"
                US(234) = "duotrigintaducentillion"
                US(235) = "trestrigintaducentillion"
                US(236) = "quattuortrigintaducentillion"
                US(237) = "quinquatrigintaducentillion"
                US(238) = "sestrigintaducentillion"
                US(239) = "septentrigintaducentillion"
                US(240) = "octotrigintaducentillion"
                US(241) = "noventrigintaducentillion"
                US(242) = "quadragintaducentillion"
                US(243) = "unquadragintaducentillion"
                US(244) = "duoquadragintaducentillion"
                US(245) = "tresquadragintaducentillion"
                US(246) = "quattuorquadragintaducentillion"
                US(247) = "quinquaquadragintaducentillion"
                US(248) = "sesquadragintaducentillion"
                US(249) = "septenquadragintaducentillion"
                US(250) = "octoquadragintaducentillion"
                US(251) = "novenquadragintaducentillion"
                US(252) = "quinquagintaducentillion"
                US(253) = "unquinquagintaducentillion"
                US(254) = "duoquinquagintaducentillion"
                US(255) = "tresquinquagintaducentillion"
                US(256) = "quattuorquinquagintaducentillion"
                US(257) = "quinquaquinquagintaducentillion"
                US(258) = "sesquinquagintaducentillion"
                US(259) = "septenquinquagintaducentillion"
                US(260) = "octoquinquagintaducentillion"
                US(261) = "novenquinquagintaducentillion"
                US(262) = "sexagintaducentillion"
                US(263) = "unsexagintaducentillion"
                US(264) = "duosexagintaducentillion"
                US(265) = "tresexagintaducentillion"
                US(266) = "quattuorsexagintaducentillion"
                US(267) = "quinquasexagintaducentillion"
                US(268) = "sesexagintaducentillion"
                US(269) = "septensexagintaducentillion"
                US(270) = "octosexagintaducentillion"
                US(271) = "novensexagintaducentillion"
                US(272) = "septuagintaducentillion"
                US(273) = "unseptuagintaducentillion"
                US(274) = "duoseptuagintaducentillion"
                US(275) = "treseptuagintaducentillion"
                US(276) = "quattuorseptuagintaducentillion"
                US(277) = "quinquaseptuagintaducentillion"
                US(278) = "seseptuagintaducentillion"
                US(279) = "septenseptuagintaducentillion"
                US(280) = "octoseptuagintaducentillion"
                US(281) = "novenseptuagintaducentillion"
                US(282) = "octogintaducentillion"
                US(283) = "unoctogintaducentillion"
                US(284) = "duooctogintaducentillion"
                US(285) = "tresoctogintaducentillion"
                US(286) = "quattuoroctogintaducentillion"
                US(287) = "quinquaoctogintaducentillion"
                US(288) = "sexoctogintaducentillion"
                US(289) = "septemoctogintaducentillion"
                US(290) = "octooctogintaducentillion"
                US(291) = "novemoctogintaducentillion"
                US(292) = "nonagintaducentillion"
                US(293) = "unnonagintaducentillion"
                US(294) = "duononagintaducentillion"
                US(295) = "trenonagintaducentillion"
                US(296) = "quattuornonagintaducentillion"
                US(297) = "quinquanonagintaducentillion"
                US(298) = "senonagintaducentillion"
                US(299) = "septenonagintaducentillion"
                US(300) = "octononagintaducentillion"
                US(301) = "novenonagintaducentillion"
                US(302) = "trecentillion"
                US(303) = "untrecentillion"
                US(304) = "duotrecentillion"
                US(305) = "trestrecentillion"
                US(306) = "quattuortrecentillion"
                US(307) = "quinquatrecentillion"
                US(308) = "sestrecentillion"
                US(309) = "septentrecentillion"
                US(310) = "octotrecentillion"
                US(311) = "noventrecentillion"
                US(312) = "decitrecentillion"
                US(313) = "undecitrecentillion"
                US(314) = "duodecitrecentillion"
                US(315) = "tredecitrecentillion"
                US(316) = "quattuordecitrecentillion"
                US(317) = "quinquadecitrecentillion"
                US(318) = "sedecitrecentillion"
                US(319) = "septendecitrecentillion"
                US(320) = "octodecitrecentillion"
                US(321) = "novendecitrecentillion"
                US(322) = "vigintitrecentillion"
                US(323) = "unvigintitrecentillion"
                US(324) = "duovigintitrecentillion"
                US(325) = "tresvigintitrecentillion"
                US(326) = "quattuorvigintitrecentillion"
                US(327) = "quinquavigintitrecentillion"
                US(328) = "sesvigintitrecentillion"
                US(329) = "septemvigintitrecentillion"
                US(330) = "octovigintitrecentillion"
                US(331) = "novemvigintitrecentillion"
                US(332) = "trigintatrecentillion"
                US(333) = "untrigintatrecentillion"
                US(334) = "duotrigintatrecentillion"
                US(335) = "trestrigintatrecentillion"
                US(336) = "quattuortrigintatrecentillion"
                US(337) = "quinquatrigintatrecentillion"
                US(338) = "sestrigintatrecentillion"
                US(339) = "septentrigintatrecentillion"
                US(340) = "octotrigintatrecentillion"
                US(341) = "noventrigintatrecentillion"
                US(342) = "quadragintatrecentillion"
                US(343) = "unquadragintatrecentillion"
                US(344) = "duoquadragintatrecentillion"
                US(345) = "tresquadragintatrecentillion"
                US(346) = "quattuorquadragintatrecentillion"
                US(347) = "quinquaquadragintatrecentillion"
                US(348) = "sesquadragintatrecentillion"
                US(349) = "septenquadragintatrecentillion"
                US(350) = "octoquadragintatrecentillion"
                US(351) = "novenquadragintatrecentillion"
                US(352) = "quinquagintatrecentillion"
                US(353) = "unquinquagintatrecentillion"
                US(354) = "duoquinquagintatrecentillion"
                US(355) = "tresquinquagintatrecentillion"
                US(356) = "quattuorquinquagintatrecentillion"
                US(357) = "quinquaquinquagintatrecentillion"
                US(358) = "sesquinquagintatrecentillion"
                US(359) = "septenquinquagintatrecentillion"
                US(360) = "octoquinquagintatrecentillion"
                US(361) = "novenquinquagintatrecentillion"
                US(362) = "sexagintatrecentillion"
                US(363) = "unsexagintatrecentillion"
                US(364) = "duosexagintatrecentillion"
                US(365) = "tresexagintatrecentillion"
                US(366) = "quattuorsexagintatrecentillion"
                US(367) = "quinquasexagintatrecentillion"
                US(368) = "sesexagintatrecentillion"
                US(369) = "septensexagintatrecentillion"
                US(370) = "octosexagintatrecentillion"
                US(371) = "novensexagintatrecentillion"
                US(372) = "septuagintatrecentillion"
                US(373) = "unseptuagintatrecentillion"
                US(374) = "duoseptuagintatrecentillion"
                US(375) = "treseptuagintatrecentillion"
                US(376) = "quattuorseptuagintatrecentillion"
                US(377) = "quinquaseptuagintatrecentillion"
                US(378) = "seseptuagintatrecentillion"
                US(379) = "septenseptuagintatrecentillion"
                US(380) = "octoseptuagintatrecentillion"
                US(381) = "novenseptuagintatrecentillion"
                US(382) = "octogintatrecentillion"
                US(383) = "unoctogintatrecentillion"
                US(384) = "duooctogintatrecentillion"
                US(385) = "tresoctogintatrecentillion"
                US(386) = "quattuoroctogintatrecentillion"
                US(387) = "quinquaoctogintatrecentillion"
                US(388) = "sexoctogintatrecentillion"
                US(389) = "septemoctogintatrecentillion"
                US(390) = "octooctogintatrecentillion"
                US(391) = "novemoctogintatrecentillion"
                US(392) = "nonagintatrecentillion"
                US(393) = "unnonagintatrecentillion"
                US(394) = "duononagintatrecentillion"
                US(395) = "trenonagintatrecentillion"
                US(396) = "quattuornonagintatrecentillion"
                US(397) = "quinquanonagintatrecentillion"
                US(398) = "senonagintatrecentillion"
                US(399) = "septenonagintatrecentillion"
                US(400) = "octononagintatrecentillion"
                US(401) = "novenonagintatrecentillion"
                US(402) = "quadringentillion"
                US(403) = "unquadringentillion"
                US(404) = "duoquadringentillion"
                US(405) = "tresquadringentillion"
                US(406) = "quattuorquadringentillion"
                US(407) = "quinquaquadringentillion"
                US(408) = "sesquadringentillion"
                US(409) = "septenquadringentillion"
                US(410) = "octoquadringentillion"
                US(411) = "novenquadringentillion"
                US(412) = "deciquadringentillion"
                US(413) = "undeciquadringentillion"
                US(414) = "duodeciquadringentillion"
                US(415) = "tredeciquadringentillion"
                US(416) = "quattuordeciquadringentillion"
                US(417) = "quinquadeciquadringentillion"
                US(418) = "sedeciquadringentillion"
                US(419) = "septendeciquadringentillion"
                US(420) = "octodeciquadringentillion"
                US(421) = "novendeciquadringentillion"
                US(422) = "vigintiquadringentillion"
                US(423) = "unvigintiquadringentillion"
                US(424) = "duovigintiquadringentillion"
                US(425) = "tresvigintiquadringentillion"
                US(426) = "quattuorvigintiquadringentillion"
                US(427) = "quinquavigintiquadringentillion"
                US(428) = "sesvigintiquadringentillion"
                US(429) = "septemvigintiquadringentillion"
                US(430) = "octovigintiquadringentillion"
                US(431) = "novemvigintiquadringentillion"
                US(432) = "trigintaquadringentillion"
                US(433) = "untrigintaquadringentillion"
                US(434) = "duotrigintaquadringentillion"
                US(435) = "trestrigintaquadringentillion"
                US(436) = "quattuortrigintaquadringentillion"
                US(437) = "quinquatrigintaquadringentillion"
                US(438) = "sestrigintaquadringentillion"
                US(439) = "septentrigintaquadringentillion"
                US(440) = "octotrigintaquadringentillion"
                US(441) = "noventrigintaquadringentillion"
                US(442) = "quadragintaquadringentillion"
                US(443) = "unquadragintaquadringentillion"
                US(444) = "duoquadragintaquadringentillion"
                US(445) = "tresquadragintaquadringentillion"
                US(446) = "quattuorquadragintaquadringentillion"
                US(447) = "quinquaquadragintaquadringentillion"
                US(448) = "sesquadragintaquadringentillion"
                US(449) = "septenquadragintaquadringentillion"
                US(450) = "octoquadragintaquadringentillion"
                US(451) = "novenquadragintaquadringentillion"
                US(452) = "quinquagintaquadringentillion"
                US(453) = "unquinquagintaquadringentillion"
                US(454) = "duoquinquagintaquadringentillion"
                US(455) = "tresquinquagintaquadringentillion"
                US(456) = "quattuorquinquagintaquadringentillion"
                US(457) = "quinquaquinquagintaquadringentillion"
                US(458) = "sesquinquagintaquadringentillion"
                US(459) = "septenquinquagintaquadringentillion"
                US(460) = "octoquinquagintaquadringentillion"
                US(461) = "novenquinquagintaquadringentillion"
                US(462) = "sexagintaquadringentillion"
                US(463) = "unsexagintaquadringentillion"
                US(464) = "duosexagintaquadringentillion"
                US(465) = "tresexagintaquadringentillion"
                US(466) = "quattuorsexagintaquadringentillion"
                US(467) = "quinquasexagintaquadringentillion"
                US(468) = "sesexagintaquadringentillion"
                US(469) = "septensexagintaquadringentillion"
                US(470) = "octosexagintaquadringentillion"
                US(471) = "novensexagintaquadringentillion"
                US(472) = "septuagintaquadringentillion"
                US(473) = "unseptuagintaquadringentillion"
                US(474) = "duoseptuagintaquadringentillion"
                US(475) = "treseptuagintaquadringentillion"
                US(476) = "quattuorseptuagintaquadringentillion"
                US(477) = "quinquaseptuagintaquadringentillion"
                US(478) = "seseptuagintaquadringentillion"
                US(479) = "septenseptuagintaquadringentillion"
                US(480) = "octoseptuagintaquadringentillion"
                US(481) = "novenseptuagintaquadringentillion"
                US(482) = "octogintaquadringentillion"
                US(483) = "unoctogintaquadringentillion"
                US(484) = "duooctogintaquadringentillion"
                US(485) = "tresoctogintaquadringentillion"
                US(486) = "quattuoroctogintaquadringentillion"
                US(487) = "quinquaoctogintaquadringentillion"
                US(488) = "sexoctogintaquadringentillion"
                US(489) = "septemoctogintaquadringentillion"
                US(490) = "octooctogintaquadringentillion"
                US(491) = "novemoctogintaquadringentillion"
                US(492) = "nonagintaquadringentillion"
                US(493) = "unnonagintaquadringentillion"
                US(494) = "duononagintaquadringentillion"
                US(495) = "trenonagintaquadringentillion"
                US(496) = "quattuornonagintaquadringentillion"
                US(497) = "quinquanonagintaquadringentillion"
                US(498) = "senonagintaquadringentillion"
                US(499) = "septenonagintaquadringentillion"
                US(500) = "octononagintaquadringentillion"
                US(501) = "novenonagintaquadringentillion"
                US(502) = "quingentillion"
                US(503) = "unquingentillion"
                US(504) = "duoquingentillion"
                US(505) = "tresquingentillion"
                US(506) = "quattuorquingentillion"
                US(507) = "quinquaquingentillion"
                US(508) = "sesquingentillion"
                US(509) = "septenquingentillion"
                US(510) = "octoquingentillion"
                US(511) = "novenquingentillion"
                US(512) = "deciquingentillion"
                US(513) = "undeciquingentillion"
                US(514) = "duodeciquingentillion"
                US(515) = "tredeciquingentillion"
                US(516) = "quattuordeciquingentillion"
                US(517) = "quinquadeciquingentillion"
                US(518) = "sedeciquingentillion"
                US(519) = "septendeciquingentillion"
                US(520) = "octodeciquingentillion"
                US(521) = "novendeciquingentillion"
                US(522) = "vigintiquingentillion"
                US(523) = "unvigintiquingentillion"
                US(524) = "duovigintiquingentillion"
                US(525) = "tresvigintiquingentillion"
                US(526) = "quattuorvigintiquingentillion"
                US(527) = "quinquavigintiquingentillion"
                US(528) = "sesvigintiquingentillion"
                US(529) = "septemvigintiquingentillion"
                US(530) = "octovigintiquingentillion"
                US(531) = "novemvigintiquingentillion"
                US(532) = "trigintaquingentillion"
                US(533) = "untrigintaquingentillion"
                US(534) = "duotrigintaquingentillion"
                US(535) = "trestrigintaquingentillion"
                US(536) = "quattuortrigintaquingentillion"
                US(537) = "quinquatrigintaquingentillion"
                US(538) = "sestrigintaquingentillion"
                US(539) = "septentrigintaquingentillion"
                US(540) = "octotrigintaquingentillion"
                US(541) = "noventrigintaquingentillion"
                US(542) = "quadragintaquingentillion"
                US(543) = "unquadragintaquingentillion"
                US(544) = "duoquadragintaquingentillion"
                US(545) = "tresquadragintaquingentillion"
                US(546) = "quattuorquadragintaquingentillion"
                US(547) = "quinquaquadragintaquingentillion"
                US(548) = "sesquadragintaquingentillion"
                US(549) = "septenquadragintaquingentillion"
                US(550) = "octoquadragintaquingentillion"
                US(551) = "novenquadragintaquingentillion"
                US(552) = "quinquagintaquingentillion"
                US(553) = "unquinquagintaquingentillion"
                US(554) = "duoquinquagintaquingentillion"
                US(555) = "tresquinquagintaquingentillion"
                US(556) = "quattuorquinquagintaquingentillion"
                US(557) = "quinquaquinquagintaquingentillion"
                US(558) = "sesquinquagintaquingentillion"
                US(559) = "septenquinquagintaquingentillion"
                US(560) = "octoquinquagintaquingentillion"
                US(561) = "novenquinquagintaquingentillion"
                US(562) = "sexagintaquingentillion"
                US(563) = "unsexagintaquingentillion"
                US(564) = "duosexagintaquingentillion"
                US(565) = "tresexagintaquingentillion"
                US(566) = "quattuorsexagintaquingentillion"
                US(567) = "quinquasexagintaquingentillion"
                US(568) = "sesexagintaquingentillion"
                US(569) = "septensexagintaquingentillion"
                US(570) = "octosexagintaquingentillion"
                US(571) = "novensexagintaquingentillion"
                US(572) = "septuagintaquingentillion"
                US(573) = "unseptuagintaquingentillion"
                US(574) = "duoseptuagintaquingentillion"
                US(575) = "treseptuagintaquingentillion"
                US(576) = "quattuorseptuagintaquingentillion"
                US(577) = "quinquaseptuagintaquingentillion"
                US(578) = "seseptuagintaquingentillion"
                US(579) = "septenseptuagintaquingentillion"
                US(580) = "octoseptuagintaquingentillion"
                US(581) = "novenseptuagintaquingentillion"
                US(582) = "octogintaquingentillion"
                US(583) = "unoctogintaquingentillion"
                US(584) = "duooctogintaquingentillion"
                US(585) = "tresoctogintaquingentillion"
                US(586) = "quattuoroctogintaquingentillion"
                US(587) = "quinquaoctogintaquingentillion"
                US(588) = "sexoctogintaquingentillion"
                US(589) = "septemoctogintaquingentillion"
                US(590) = "octooctogintaquingentillion"
                US(591) = "novemoctogintaquingentillion"
                US(592) = "nonagintaquingentillion"
                US(593) = "unnonagintaquingentillion"
                US(594) = "duononagintaquingentillion"
                US(595) = "trenonagintaquingentillion"
                US(596) = "quattuornonagintaquingentillion"
                US(597) = "quinquanonagintaquingentillion"
                US(598) = "senonagintaquingentillion"
                US(599) = "septenonagintaquingentillion"
                US(600) = "octononagintaquingentillion"
                US(601) = "novenonagintaquingentillion"
                US(602) = "sescentillion"
                US(603) = "unsescentillion"
                US(604) = "duosescentillion"
                US(605) = "tresescentillion"
                US(606) = "quattuorsescentillion"
                US(607) = "quinquasescentillion"
                US(608) = "sesescentillion"
                US(609) = "septensescentillion"
                US(610) = "octosescentillion"
                US(611) = "novensescentillion"
                US(612) = "decisescentillion"
                US(613) = "undecisescentillion"
                US(614) = "duodecisescentillion"
                US(615) = "tredecisescentillion"
                US(616) = "quattuordecisescentillion"
                US(617) = "quinquadecisescentillion"
                US(618) = "sedecisescentillion"
                US(619) = "septendecisescentillion"
                US(620) = "octodecisescentillion"
                US(621) = "novendecisescentillion"
                US(622) = "vigintisescentillion"
                US(623) = "unvigintisescentillion"
                US(624) = "duovigintisescentillion"
                US(625) = "tresvigintisescentillion"
                US(626) = "quattuorvigintisescentillion"
                US(627) = "quinquavigintisescentillion"
                US(628) = "sesvigintisescentillion"
                US(629) = "septemvigintisescentillion"
                US(630) = "octovigintisescentillion"
                US(631) = "novemvigintisescentillion"
                US(632) = "trigintasescentillion"
                US(633) = "untrigintasescentillion"
                US(634) = "duotrigintasescentillion"
                US(635) = "trestrigintasescentillion"
                US(636) = "quattuortrigintasescentillion"
                US(637) = "quinquatrigintasescentillion"
                US(638) = "sestrigintasescentillion"
                US(639) = "septentrigintasescentillion"
                US(640) = "octotrigintasescentillion"
                US(641) = "noventrigintasescentillion"
                US(642) = "quadragintasescentillion"
                US(643) = "unquadragintasescentillion"
                US(644) = "duoquadragintasescentillion"
                US(645) = "tresquadragintasescentillion"
                US(646) = "quattuorquadragintasescentillion"
                US(647) = "quinquaquadragintasescentillion"
                US(648) = "sesquadragintasescentillion"
                US(649) = "septenquadragintasescentillion"
                US(650) = "octoquadragintasescentillion"
                US(651) = "novenquadragintasescentillion"
                US(652) = "quinquagintasescentillion"
                US(653) = "unquinquagintasescentillion"
                US(654) = "duoquinquagintasescentillion"
                US(655) = "tresquinquagintasescentillion"
                US(656) = "quattuorquinquagintasescentillion"
                US(657) = "quinquaquinquagintasescentillion"
                US(658) = "sesquinquagintasescentillion"
                US(659) = "septenquinquagintasescentillion"
                US(660) = "octoquinquagintasescentillion"
                US(661) = "novenquinquagintasescentillion"
                US(662) = "sexagintasescentillion"
                US(663) = "unsexagintasescentillion"
                US(664) = "duosexagintasescentillion"
                US(665) = "tresexagintasescentillion"
                US(666) = "quattuorsexagintasescentillion"
                US(667) = "quinquasexagintasescentillion"
                US(668) = "sesexagintasescentillion"
                US(669) = "septensexagintasescentillion"
                US(670) = "octosexagintasescentillion"
                US(671) = "novensexagintasescentillion"
                US(672) = "septuagintasescentillion"
                US(673) = "unseptuagintasescentillion"
                US(674) = "duoseptuagintasescentillion"
                US(675) = "treseptuagintasescentillion"
                US(676) = "quattuorseptuagintasescentillion"
                US(677) = "quinquaseptuagintasescentillion"
                US(678) = "seseptuagintasescentillion"
                US(679) = "septenseptuagintasescentillion"
                US(680) = "octoseptuagintasescentillion"
                US(681) = "novenseptuagintasescentillion"
                US(682) = "octogintasescentillion"
                US(683) = "unoctogintasescentillion"
                US(684) = "duooctogintasescentillion"
                US(685) = "tresoctogintasescentillion"
                US(686) = "quattuoroctogintasescentillion"
                US(687) = "quinquaoctogintasescentillion"
                US(688) = "sexoctogintasescentillion"
                US(689) = "septemoctogintasescentillion"
                US(680) = "octooctogintasescentillion"
                US(691) = "novemoctogintasescentillion"
                US(692) = "nonagintasescentillion"
                US(693) = "unnonagintasescentillion"
                US(694) = "duononagintasescentillion"
                US(695) = "trenonagintasescentillion"
                US(696) = "quattuornonagintasescentillion"
                US(697) = "quinquanonagintasescentillion"
                US(698) = "senonagintasescentillion"
                US(699) = "septenonagintasescentillion"
                US(700) = "octononagintasescentillion"
                US(701) = "novenonagintasescentillion"
                US(702) = "septingentillion"
                US(703) = "unseptingentillion"
                US(704) = "duoseptingentillion"
                US(705) = "treseptingentillion"
                US(706) = "quattuorseptingentillion"
                US(707) = "quinquaseptingentillion"
                US(708) = "seseptingentillion"
                US(709) = "septenseptingentillion"
                US(710) = "octoseptingentillion"
                US(711) = "novenseptingentillion"
                US(712) = "deciseptingentillion"
                US(713) = "undeciseptingentillion"
                US(714) = "duodeciseptingentillion"
                US(715) = "tredeciseptingentillion"
                US(716) = "quattuordeciseptingentillion"
                US(717) = "quinquadeciseptingentillion"
                US(718) = "sedeciseptingentillion"
                US(719) = "septendeciseptingentillion"
                US(720) = "octodeciseptingentillion"
                US(721) = "novendeciseptingentillion"
                US(722) = "vigintiseptingentillion"
                US(723) = "unvigintiseptingentillion"
                US(724) = "duovigintiseptingentillion"
                US(725) = "tresvigintiseptingentillion"
                US(726) = "quattuorvigintiseptingentillion"
                US(727) = "quinquavigintiseptingentillion"
                US(728) = "sesvigintiseptingentillion"
                US(729) = "septemvigintiseptingentillion"
                US(730) = "octovigintiseptingentillion"
                US(731) = "novemvigintiseptingentillion"
                US(732) = "trigintaseptingentillion"
                US(733) = "untrigintaseptingentillion"
                US(734) = "duotrigintaseptingentillion"
                US(735) = "trestrigintaseptingentillion"
                US(736) = "quattuortrigintaseptingentillion"
                US(737) = "quinquatrigintaseptingentillion"
                US(738) = "sestrigintaseptingentillion"
                US(739) = "septentrigintaseptingentillion"
                US(740) = "octotrigintaseptingentillion"
                US(741) = "noventrigintaseptingentillion"
                US(742) = "quadragintaseptingentillion"
                US(743) = "unquadragintaseptingentillion"
                US(744) = "duoquadragintaseptingentillion"
                US(745) = "tresquadragintaseptingentillion"
                US(746) = "quattuorquadragintaseptingentillion"
                US(747) = "quinquaquadragintaseptingentillion"
                US(748) = "sesquadragintaseptingentillion"
                US(749) = "septenquadragintaseptingentillion"
                US(750) = "octoquadragintaseptingentillion"
                US(751) = "novenquadragintaseptingentillion"
                US(752) = "quinquagintaseptingentillion"
                US(753) = "unquinquagintaseptingentillion"
                US(754) = "duoquinquagintaseptingentillion"
                US(755) = "tresquinquagintaseptingentillion"
                US(756) = "quattuorquinquagintaseptingentillion"
                US(757) = "quinquaquinquagintaseptingentillion"
                US(758) = "sesquinquagintaseptingentillion"
                US(759) = "septenquinquagintaseptingentillion"
                US(760) = "octoquinquagintaseptingentillion"
                US(761) = "novenquinquagintaseptingentillion"
                US(762) = "sexagintaseptingentillion"
                US(763) = "unsexagintaseptingentillion"
                US(764) = "duosexagintaseptingentillion"
                US(765) = "tresexagintaseptingentillion"
                US(766) = "quattuorsexagintaseptingentillion"
                US(767) = "quinquasexagintaseptingentillion"
                US(768) = "sesexagintaseptingentillion"
                US(769) = "septensexagintaseptingentillion"
                US(770) = "octosexagintaseptingentillion"
                US(771) = "novensexagintaseptingentillion"
                US(772) = "septuagintaseptingentillion"
                US(773) = "unseptuagintaseptingentillion"
                US(774) = "duoseptuagintaseptingentillion"
                US(775) = "treseptuagintaseptingentillion"
                US(776) = "quattuorseptuagintaseptingentillion"
                US(777) = "quinquaseptuagintaseptingentillion"
                US(778) = "seseptuagintaseptingentillion"
                US(779) = "septenseptuagintaseptingentillion"
                US(780) = "octoseptuagintaseptingentillion"
                US(781) = "novenseptuagintaseptingentillion"
                US(782) = "octogintaseptingentillion"
                US(783) = "unoctogintaseptingentillion"
                US(784) = "duooctogintaseptingentillion"
                US(785) = "tresoctogintaseptingentillion"
                US(786) = "quattuoroctogintaseptingentillion"
                US(787) = "quinquaoctogintaseptingentillion"
                US(788) = "sexoctogintaseptingentillion"
                US(789) = "septemoctogintaseptingentillion"
                US(790) = "octooctogintaseptingentillion"
                US(791) = "novemoctogintaseptingentillion"
                US(792) = "nonagintaseptingentillion"
                US(793) = "unnonagintaseptingentillion"
                US(794) = "duononagintaseptingentillion"
                US(795) = "trenonagintaseptingentillion"
                US(796) = "quattuornonagintaseptingentillion"
                US(797) = "quinquanonagintaseptingentillion"
                US(798) = "senonagintaseptingentillion"
                US(799) = "septenonagintaseptingentillion"
                US(800) = "octononagintaseptingentillion"
                US(801) = "novenonagintaseptingentillion"
                US(802) = "octingentillion"
                US(803) = "unoctingentillion"
                US(804) = "duooctingentillion"
                US(805) = "tresoctingentillion"
                US(806) = "quattuoroctingentillion"
                US(807) = "quinquaoctingentillion"
                US(808) = "sexoctingentillion"
                US(809) = "septemoctingentillion"
                US(810) = "octooctingentillion"
                US(811) = "novemoctingentillion"
                US(812) = "decioctingentillion"
                US(813) = "undecioctingentillion"
                US(814) = "duodecioctingentillion"
                US(815) = "tredecioctingentillion"
                US(816) = "quattuordecioctingentillion"
                US(817) = "quinquadecioctingentillion"
                US(818) = "sedecioctingentillion"
                US(819) = "septendecioctingentillion"
                US(820) = "octodecioctingentillion"
                US(821) = "novendecioctingentillion"
                US(822) = "vigintioctingentillion"
                US(823) = "unvigintioctingentillion"
                US(824) = "duovigintioctingentillion"
                US(825) = "tresvigintioctingentillion"
                US(826) = "quattuorvigintioctingentillion"
                US(827) = "quinquavigintioctingentillion"
                US(828) = "sesvigintioctingentillion"
                US(829) = "septemvigintioctingentillion"
                US(830) = "octovigintioctingentillion"
                US(831) = "novemvigintioctingentillion"
                US(832) = "trigintaoctingentillion"
                US(833) = "untrigintaoctingentillion"
                US(834) = "duotrigintaoctingentillion"
                US(835) = "trestrigintaoctingentillion"
                US(836) = "quattuortrigintaoctingentillion"
                US(837) = "quinquatrigintaoctingentillion"
                US(838) = "sestrigintaoctingentillion"
                US(839) = "septentrigintaoctingentillion"
                US(840) = "octotrigintaoctingentillion"
                US(841) = "noventrigintaoctingentillion"
                US(842) = "quadragintaoctingentillion"
                US(843) = "unquadragintaoctingentillion"
                US(844) = "duoquadragintaoctingentillion"
                US(845) = "tresquadragintaoctingentillion"
                US(846) = "quattuorquadragintaoctingentillion"
                US(847) = "quinquaquadragintaoctingentillion"
                US(848) = "sesquadragintaoctingentillion"
                US(849) = "septenquadragintaoctingentillion"
                US(850) = "octoquadragintaoctingentillion"
                US(851) = "novenquadragintaoctingentillion"
                US(852) = "quinquagintaoctingentillion"
                US(853) = "unquinquagintaoctingentillion"
                US(854) = "duoquinquagintaoctingentillion"
                US(855) = "tresquinquagintaoctingentillion"
                US(856) = "quattuorquinquagintaoctingentillion"
                US(857) = "quinquaquinquagintaoctingentillion"
                US(858) = "sesquinquagintaoctingentillion"
                US(859) = "septenquinquagintaoctingentillion"
                US(860) = "octoquinquagintaoctingentillion"
                US(861) = "novenquinquagintaoctingentillion"
                US(862) = "sexagintaoctingentillion"
                US(863) = "unsexagintaoctingentillion"
                US(864) = "duosexagintaoctingentillion"
                US(865) = "tresexagintaoctingentillion"
                US(866) = "quattuorsexagintaoctingentillion"
                US(867) = "quinquasexagintaoctingentillion"
                US(868) = "sesexagintaoctingentillion"
                US(879) = "septensexagintaoctingentillion"
                US(870) = "octosexagintaoctingentillion"
                US(871) = "novensexagintaoctingentillion"
                US(872) = "septuagintaoctingentillion"
                US(873) = "unseptuagintaoctingentillion"
                US(874) = "duoseptuagintaoctingentillion"
                US(875) = "treseptuagintaoctingentillion"
                US(876) = "quattuorseptuagintaoctingentillion"
                US(877) = "quinquaseptuagintaoctingentillion"
                US(878) = "seseptuagintaoctingentillion"
                US(879) = "septenseptuagintaoctingentillion"
                US(880) = "octoseptuagintaoctingentillion"
                US(881) = "novenseptuagintaoctingentillion"
                US(882) = "octogintaoctingentillion"
                US(883) = "unoctogintaoctingentillion"
                US(884) = "duooctogintaoctingentillion"
                US(885) = "tresoctogintaoctingentillion"
                US(886) = "quattuoroctogintaoctingentillion"
                US(887) = "quinquaoctogintaoctingentillion"
                US(888) = "sexoctogintaoctingentillion"
                US(889) = "septemoctogintaoctingentillion"
                US(890) = "octooctogintaoctingentillion"
                US(891) = "novemoctogintaoctingentillion"
                US(892) = "nonagintaoctingentillion"
                US(893) = "unnonagintaoctingentillion"
                US(894) = "duononagintaoctingentillion"
                US(895) = "trenonagintaoctingentillion"
                US(896) = "quattuornonagintaoctingentillion"
                US(897) = "quinquanonagintaoctingentillion"
                US(898) = "senonagintaoctingentillion"
                US(899) = "septenonagintaoctingentillion"
                US(900) = "octononagintaoctingentillion"
                US(901) = "novenonagintaoctingentillion"
                US(902) = "nongentillion"
                US(903) = "unnongentillion"
                US(904) = "duonongentillion"
                US(905) = "trenongentillion"
                US(906) = "quattuornongentillion"
                US(907) = "quinquanongentillion"
                US(908) = "senongentillion"
                US(909) = "septenongentillion"
                US(910) = "octonongentillion"
                US(911) = "novenongentillion"
                US(912) = "decinongentillion"
                US(913) = "undecinongentillion"
                US(914) = "duodecinongentillion"
                US(915) = "tredecinongentillion"
                US(916) = "quattuordecinongentillion"
                US(917) = "quinquadecinongentillion"
                US(918) = "sedecinongentillion"
                US(919) = "septendecinongentillion"
                US(920) = "octodecinongentillion"
                US(921) = "novendecinongentillion"
                US(922) = "vigintinongentillion"
                US(923) = "unvigintinongentillion"
                US(924) = "duovigintinongentillion"
                US(925) = "tresvigintinongentillion"
                US(926) = "quattuorvigintinongentillion"
                US(927) = "quinquavigintinongentillion"
                US(928) = "sesvigintinongentillion"
                US(929) = "septemvigintinongentillion"
                US(930) = "octovigintinongentillion"
                US(931) = "novemvigintinongentillion"
                US(932) = "trigintanongentillion"
                US(933) = "untrigintanongentillion"
                US(934) = "duotrigintanongentillion"
                US(935) = "trestrigintanongentillion"
                US(936) = "quattuortrigintanongentillion"
                US(937) = "quinquatrigintanongentillion"
                US(938) = "sestrigintanongentillion"
                US(939) = "septentrigintanongentillion"
                US(940) = "octotrigintanongentillion"
                US(941) = "noventrigintanongentillion"
                US(942) = "quadragintanongentillion"
                US(943) = "unquadragintanongentillion"
                US(944) = "duoquadragintanongentillion"
                US(945) = "tresquadragintanongentillion"
                US(946) = "quattuorquadragintanongentillion"
                US(947) = "quinquaquadragintanongentillion"
                US(948) = "sesquadragintanongentillion"
                US(949) = "septenquadragintanongentillion"
                US(950) = "octoquadragintanongentillion"
                US(951) = "novenquadragintanongentillion"
                US(952) = "quinquagintanongentillion"
                US(953) = "unquinquagintanongentillion"
                US(954) = "duoquinquagintanongentillion"
                US(955) = "tresquinquagintanongentillion"
                US(956) = "quattuorquinquagintanongentillion"
                US(957) = "quinquaquinquagintanongentillion"
                US(958) = "sesquinquagintanongentillion"
                US(959) = "septenquinquagintanongentillion"
                US(960) = "octoquinquagintanongentillion"
                US(961) = "novenquinquagintanongentillion"
                US(962) = "sexagintanongentillion"
                US(963) = "unsexagintanongentillion"
                US(964) = "duosexagintanongentillion"
                US(965) = "tresexagintanongentillion"
                US(966) = "quattuorsexagintanongentillion"
                US(967) = "quinquasexagintanongentillion"
                US(968) = "sesexagintanongentillion"
                US(969) = "septensexagintanongentillion"
                US(970) = "octosexagintanongentillion"
                US(971) = "novensexagintanongentillion"
                US(972) = "septuagintanongentillion"
                US(973) = "unseptuagintanongentillion"
                US(974) = "duoseptuagintanongentillion"
                US(975) = "treseptuagintanongentillion"
                US(976) = "quattuorseptuagintanongentillion"
                US(977) = "quinquaseptuagintanongentillion"
                US(978) = "seseptuagintanongentillion"
                US(979) = "septenseptuagintanongentillion"
                US(980) = "octoseptuagintanongentillion"
                US(981) = "novenseptuagintanongentillion"
                US(982) = "octogintanongentillion"
                US(983) = "unoctogintanongentillion"
                US(984) = "duooctogintanongentillion"
                US(985) = "tresoctogintanongentillion"
                US(986) = "quattuoroctogintanongentillion"
                US(987) = "quinquaoctogintanongentillion"
                US(988) = "sexoctogintanongentillion"
                US(989) = "septemoctogintanongentillion"
                US(990) = "octooctogintanongentillion"
                US(991) = "novemoctogintanongentillion"
                US(992) = "nonagintanongentillion"
                US(993) = "unnonagintanongentillion"
                US(994) = "duononagintanongentillion"
                US(995) = "trenonagintanongentillion"
                US(996) = "quattuornonagintanongentillion"
                US(997) = "quinquanonagintanongentillion"
                US(998) = "senonagintanongentillion"
                US(999) = "septenonagintanongentillion"
                US(1000) = "octononagintanongentillion"
                US(1001) = "novenonagintanongentillion"
                US(1002) = "millillion"

            End Sub

            ''' <summary>
            ''' It converts from number into words
            ''' </summary>
            ''' <param name="values">Set the number to convert</param>
            ''' <param name="Extension">Set the brief extension name of the number</param>
            ''' <returns>Get the converted words</returns>
            ''' <remarks></remarks>
            Public Shared Function NumberToWords(ByVal values As Object, Optional ByVal Extension As String = "cents") As String

                Dim lb As Boolean = False
                Dim Test1 As String = "0"
                Dim Test2 As String = "0"

                If TypeOf values Is Integer Or TypeOf values Is Long Or TypeOf values Is Int16 Or TypeOf values Is Int32 Or TypeOf values Is Int64 Then
                    Dim nvalues As String = values.ToString.Replace(",", "")
                    Test1 = Test1
                ElseIf TypeOf values Is Double Or TypeOf values Is Decimal Or TypeOf values Is String Then
                    Dim nvalues As String = values.ToString.Replace(",", "")
                    If IsNumeric(nvalues) Then
                        If nvalues.Contains(".") Then
                            Dim nval() As String = nvalues.Split(".")
                            If nval.Length = 2 Then
                                If Val(nval(1)) > 0 Then
                                    lb = True
                                    Test1 = Trim(nval(0))
                                    Test2 = Trim(nval(1))
                                Else
                                    Test1 = Trim(nval(0))
                                End If
                            ElseIf nval.Length = 1 Then
                                Test1 = Trim(nval(0))
                            Else
                                Return "Invalid Decimal Point."
                            End If
                        Else
                            Test1 = nvalues
                        End If
                    Else
                        Return "This is not a number."
                    End If
                Else
                    Return "Invalid Parameters. There is no value inside the object."
                End If

                'validate the integer

                If Val(Test1) > 0 Then
                    Dim GeneralResult As New System.Text.StringBuilder
                    With GeneralResult
                        .Append(get_ReturnWords(Test1))
                        If lb Then
                            .Append("and")
                            .Append(" " + get_ReturnWords(Test2))
                            .Append(Extension)
                        End If
                    End With

                    Return GeneralResult.ToString
                Else
                    Return "zero"
                End If
            End Function

        End Class

        Public Class Formatter

            Public Shared Function format_NumberOnly(ByVal value As Object, ByVal allow_withcomma As Boolean, Optional ByVal default_value As String = "")
                Dim cn As String = ""
                If default_value <> "" Then cn = default_value
                If allow_withcomma Then
                    If cn = "" Then
                        cn = "#,###"
                    Else
                        cn = testchar(default_value.ToString)
                    End If
                    Return Format(value, cn)
                Else
                    Return value
                End If
            End Function

            Private Shared Function testchar(ByVal v As String)
                If v <> "" Then
                    Select Case v.Length
                        Case 1
                            Return "#,##" + v
                        Case 2
                            Return "#,#" + v
                        Case 3
                            Return "#," + v
                        Case 4
                            Return v.Substring(0, 1) + "," + v.Substring(1, v.Length - 2)
                        Case Else
                    End Select
                End If
                Return "#,##"
            End Function

            Enum Type
                Set_Object
                Pass_by_Value
            End Enum

            Public Shared Function format_DecimalOnly(ByRef obj As Object, Optional ByVal decimal_range As Integer = 0, Optional ByVal types As Type = Type.Set_Object)
                Try
                    If Not obj Is Nothing Then
                        Dim value As Double = 0

                        If TypeOf obj Is Integer Or TypeOf obj Is String Or TypeOf obj Is Double Or TypeOf obj Is Long Or TypeOf obj Is Decimal Then
                            If obj = 0 Then
                                Return (0).ToString("N" + decimal_range.ToString) ' 2,793,882.42
                            Else
                                Return (CDbl(obj)).ToString("N" + decimal_range.ToString) ' 2,793,882.42
                            End If

                        Else
                            If types = Type.Set_Object Then
                                If IsNumeric(obj.text) Then
                                    value = CDbl(obj.text)
                                End If
                            Else
                                value = CDbl(obj)
                            End If

                            Dim myNumberString As String = (value).ToString("N" + decimal_range.ToString) ' 2,793,882.42
                            If types = Type.Set_Object Then
                                obj.Text = myNumberString
                            Else
                                Return myNumberString
                            End If
                        End If
                    End If

                Catch ex As Exception
                    Return (0).ToString("N" + decimal_range.ToString)
                End Try

                Return Nothing
            End Function

            Public Shared Sub clean_input_Number(ByRef str As String)
                str = System.Text.RegularExpressions.Regex.Replace(str, "[a-zA-Z\b\s-.]", "")
                If Len(str) = 0 Then
                    str = "0"
                End If
            End Sub

            Public Shared Sub clean_input_Decimal(ByRef str As String, Optional ByVal digits As Integer = 2)
                str = System.Text.RegularExpressions.Regex.Replace(str, "[a-zA-Z\b\s-]", "")
                If Len(str) = 0 Then
                    If digits = 2 Then
                        str = "0.00"
                    Else
                        str = "0.000000"
                    End If
                End If
            End Sub

        End Class

    End Namespace

End Namespace


