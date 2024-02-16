﻿namespace Humanizer.Tests.Localisation.@is
{
    [UseCulture("is")]
    public class NumberToWordsTests
    {
        [Theory]
        [InlineData(0, "núll")]
        [InlineData(1, "einn")]
        [InlineData(-10, "mínus tíu")]
        [InlineData(10, "tíu")]
        [InlineData(11, "ellefu")]
        [InlineData(122, "eitt hundrað tuttugu og tveir")]
        [InlineData(3501, "þrjú þúsund fimm hundruð og einn")]
        [InlineData(100, "eitt hundrað")]
        [InlineData(1000, "eitt þúsund")]
        [InlineData(100000, "eitt hundrað þúsund")]
        [InlineData(1000000, "ein milljón")]
        [InlineData(10000000, "tíu milljónir")]
        [InlineData(100000000, "eitt hundrað milljónir")]
        [InlineData(100000001L, "eitt hundrað milljónir og einn")]
        [InlineData(100000001L, "eitt hundrað milljónir og ein", GrammaticalGender.Feminine)]
        [InlineData(100000001L, "eitt hundrað milljónir og eitt", GrammaticalGender.Neuter)]
        [InlineData(100000002L, "eitt hundrað milljónir og tveir")]
        [InlineData(100001999L, "eitt hundrað milljónir eitt þúsund níu hundruð níutíu og níu")]
        [InlineData(100002000L, "eitt hundrað milljónir og tvö þúsund")]
        [InlineData(100002000L, "eitt hundrað milljónir og tvö þúsund", GrammaticalGender.Feminine)]
        [InlineData(100002000L, "eitt hundrað milljónir og tvö þúsund", GrammaticalGender.Neuter)]
        [InlineData(100002001L, "eitt hundrað milljónir tvö þúsund og einn")]
        [InlineData(100002002L, "eitt hundrað milljónir tvö þúsund og tveir")]
        [InlineData(100031999L, "eitt hundrað milljónir þrjátíu og eitt þúsund níu hundruð níutíu og níu")]
        [InlineData(1000000000, "einn milljarður")]
        [InlineData(111, "eitt hundrað og ellefu")]
        [InlineData(1111, "eitt þúsund eitt hundrað og ellefu")]
        [InlineData(111111, "eitt hundrað og ellefu þúsund eitt hundrað og ellefu")]
        [InlineData(1111111, "ein milljón eitt hundrað og ellefu þúsund eitt hundrað og ellefu")]
        [InlineData(11111111, "ellefu milljónir eitt hundrað og ellefu þúsund eitt hundrað og ellefu")]
        [InlineData(111111111, "eitt hundrað og ellefu milljónir eitt hundrað og ellefu þúsund eitt hundrað og ellefu")]
        [InlineData(1111111111, "einn milljarður eitt hundrað og ellefu milljónir eitt hundrað og ellefu þúsund eitt hundrað og ellefu")]
        [InlineData(10000000000L, "tíu milljarðar")]
        [InlineData(10000000001L, "tíu milljarðar og einn")]
        [InlineData(10000000002L, "tíu milljarðar og tveir")]
        [InlineData(123, "eitt hundrað tuttugu og þrír")]
        [InlineData(124, "eitt hundrað tuttugu og fjórir")]
        [InlineData(1234, "eitt þúsund tvö hundruð þrjátíu og fjórir")]
        [InlineData(12345, "tólf þúsund þrjú hundruð fjörutíu og fimm")]
        [InlineData(123456, "eitt hundrað tuttugu og þrjú þúsund fjögur hundruð fimmtíu og sex")]
        [InlineData(1234567, "ein milljón tvö hundruð þrjátíu og fjögur þúsund fimm hundruð sextíu og sjö")]
        [InlineData(12345678, "tólf milljónir þrjú hundruð fjörutíu og fimm þúsund sex hundruð sjötíu og átta")]
        [InlineData(123456789, "eitt hundrað tuttugu og þrjár milljónir fjögur hundruð fimmtíu og sex þúsund sjö hundruð áttatíu og níu")]
        [InlineData(1234567890, "einn milljarður tvö hundruð þrjátíu og fjórar milljónir fimm hundruð sextíu og sjö þúsund átta hundruð og níutíu")]
        [InlineData(1234567899, "einn milljarður tvö hundruð þrjátíu og fjórar milljónir fimm hundruð sextíu og sjö þúsund átta hundruð níutíu og níu")]
        [InlineData(108, "eitt hundrað og átta")]
        [InlineData(678, "sex hundruð sjötíu og átta")]
        [InlineData(2013, "tvö þúsund og þrettán")]
        [InlineData(2577, "tvö þúsund fimm hundruð sjötíu og sjö")]
        [InlineData(17053980, "sautján milljónir fimmtíu og þrjú þúsund níu hundruð og áttatíu")]
        [InlineData(415618, "fjögur hundruð og fimmtán þúsund sex hundruð og átján")]
        [InlineData(16415618, "sextán milljónir fjögur hundruð og fimmtán þúsund sex hundruð og átján")]
        [InlineData(322, "þrjú hundruð tuttugu og tveir")]
        [InlineData(322, "þrjú hundruð tuttugu og tvær", GrammaticalGender.Feminine)]
        public void IntToWords(long number, string expected, GrammaticalGender gender = GrammaticalGender.Masculine) =>
            Assert.Equal(expected, number.ToWords(gender));

        [Theory]
        [InlineData(100_000_000_000L, "eitt hundrað milljarðar")]
        [InlineData(1_000_000_000_000L, "ein billjón")]
        [InlineData(100_000_000_000_000L, "eitt hundrað billjónir")]
        [InlineData(1_000_000_000_000_000L, "einn billjarður")]
        [InlineData(100_000_000_000_000_000L, "eitt hundrað billjarðar")]
        [InlineData(1_000_000_000_000_000_000L, "ein trilljón")]
        [InlineData(9_223_372_036_854_775_807L, "níu trilljónir tvö hundruð tuttugu og þrír billjarðar þrjú hundruð sjötíu og tvær billjónir þrjátíu og sex milljarðar átta hundruð fimmtíu og fjórar milljónir sjö hundruð sjötíu og fimm þúsund átta hundruð og sjö")]
        public void LongToWords(long number, string expected) =>
            Assert.Equal(expected, number.ToWords());

        [Theory]
        [InlineData(0, "núllti")]
        [InlineData(1, "fyrsti")]
        [InlineData(2, "annar", GrammaticalGender.Masculine)]
        [InlineData(2, "önnur", GrammaticalGender.Feminine)]
        [InlineData(2, "annað", GrammaticalGender.Neuter)]
        [InlineData(3, "þriðji")]
        [InlineData(4, "fjórði")]
        [InlineData(5, "fimmti")]
        [InlineData(5, "fimmta", GrammaticalGender.Neuter)]
        [InlineData(6, "sjötti")]
        [InlineData(7, "sjöundi")]
        [InlineData(8, "áttundi")]
        [InlineData(9, "níundi")]
        [InlineData(10, "tíundi")]
        [InlineData(11, "ellefti")]
        [InlineData(12, "tólfti")]
        [InlineData(13, "þrettándi")]
        [InlineData(14, "fjórtándi")]
        [InlineData(15, "fimmtándi")]
        [InlineData(16, "sextándi")]
        [InlineData(17, "sautjándi")]
        [InlineData(18, "átjándi")]
        [InlineData(19, "nítjándi")]
        [InlineData(6, "sjötta", GrammaticalGender.Feminine)]
        [InlineData(7, "sjöunda", GrammaticalGender.Feminine)]
        [InlineData(8, "áttunda", GrammaticalGender.Feminine)]
        [InlineData(9, "níunda", GrammaticalGender.Feminine)]
        [InlineData(10, "tíunda", GrammaticalGender.Feminine)]
        [InlineData(11, "ellefta", GrammaticalGender.Feminine)]
        [InlineData(12, "tólfta", GrammaticalGender.Feminine)]
        [InlineData(13, "þrettánda", GrammaticalGender.Feminine)]
        [InlineData(14, "fjórtánda", GrammaticalGender.Feminine)]
        [InlineData(15, "fimmtánda", GrammaticalGender.Feminine)]
        [InlineData(16, "sextánda", GrammaticalGender.Feminine)]
        [InlineData(17, "sautjánda", GrammaticalGender.Feminine)]
        [InlineData(18, "átjánda", GrammaticalGender.Feminine)]
        [InlineData(19, "nítjánda", GrammaticalGender.Feminine)]
        [InlineData(20, "tuttugasti")]
        [InlineData(21, "tuttugasti og fyrsti")]
        [InlineData(22, "tuttugasti og annar")]
        [InlineData(30, "þrítugasti")]
        [InlineData(40, "fertugasti")]
        [InlineData(50, "fimmtugasti")]
        [InlineData(60, "sextugasti")]
        [InlineData(70, "sjötugasti")]
        [InlineData(80, "áttugasti")]
        [InlineData(90, "nítugasti")]
        [InlineData(95, "nítugasti og fimmti")]
        [InlineData(96, "nítugasti og sjötti")]
        [InlineData(44, "fertugasta og fjórða", GrammaticalGender.Feminine)]
        [InlineData(44, "fertugasti og fjórði")]
        [InlineData(77, "sjötugasti og sjöundi")]
        [InlineData(87, "áttugasta og sjöunda", GrammaticalGender.Feminine)]
        [InlineData(99, "nítugasta og níunda", GrammaticalGender.Neuter)]
        [InlineData(100, "eitt hundraðasti")]
        [InlineData(101, "eitt hundraðasti og fyrsti")]
        [InlineData(106, "eitt hundraðasti og sjötti")]
        [InlineData(108, "eitt hundraðasti og áttundi")]
        [InlineData(112, "eitt hundraðasti og tólfti")]
        [InlineData(119, "eitt hundraðasti og nítjándi")]
        [InlineData(120, "eitt hundrað og tuttugasti")]
        [InlineData(121, "eitt hundrað tuttugasti og fyrsti")]
        [InlineData(130, "eitt hundrað og þrítugasti")]
        [InlineData(131, "eitt hundrað þrítugasti og fyrsti")]
        [InlineData(1000, "eitt þúsundasta", GrammaticalGender.Feminine)]
        [InlineData(1001, "eitt þúsundasti og fyrsti")]
        [InlineData(1005, "eitt þúsundasti og fimmti")]
        [InlineData(1008, "eitt þúsundasti og áttundi")]
        [InlineData(1012, "eitt þúsundasti og tólfti")]
        [InlineData(1021, "eitt þúsund tuttugasti og fyrsti")]
        [InlineData(10000, "tíu þúsundasti")]
        [InlineData(10121, "tíu þúsund eitt hundrað tuttugasti og fyrsti")]
        [InlineData(100000, "eitt hundrað þúsundasti")]
        [InlineData(100001, "eitt hundrað þúsundasti og fyrsti")]
        [InlineData(1000000, "ein milljónasti")]
        [InlineData(2000000, "tvær milljónasti")] // https://www.mbl.is/frettir/innlent/2012/12/19/tvo_milljonasti_eda_tvimilljonasti/
        [InlineData(1530, "eitt þúsund fimm hundruð og þrítugasti")]
        [InlineData(530, "fimm hundruð og þrítugasti")]
        [InlineData(2070, "tvö þúsund og sjötugasti")]
        [InlineData(4444, "fjögur þúsund fjögur hundruð fertugasti og fjórði")]
        [InlineData(267, "tvö hundruð sextugasti og sjöundi")]
        [InlineData(700, "sjö hundruðasti")]
        [InlineData(707, "sjö hundruðasti og sjöundi")]
        [InlineData(717, "sjö hundruðasti og sautjándi")]
        [InlineData(777, "sjö hundruð sjötugasti og sjöundi")]
        [InlineData(3019, "þrjú þúsundasti og nítjándi")]
        [InlineData(5315, "fimm þúsund þrjú hundruðasti og fimmtándi")]
        [InlineData(6471, "sex þúsund fjögur hundruð sjötugasti og fyrsti")]
        [InlineData(7000, "sjö þúsundasti")]
        [InlineData(7007, "sjö þúsundasti og sjöundi")]
        [InlineData(7017, "sjö þúsundasti og sautjándi")]
        [InlineData(7777, "sjö þúsund sjö hundruð sjötugasti og sjöundi")]
        [InlineData(5315, "fimm þúsund þrjú hundruðasta og fimmtánda", GrammaticalGender.Feminine)]
        [InlineData(1044, "eitt þúsund fertugasti og fjórði")]
        [InlineData(315, "þrjú hundruðasti og fimmtándi")]
        [InlineData(777, "sjö hundruð sjötugasta og sjöunda", GrammaticalGender.Neuter)]
        [InlineData(102000, "eitt hundrað og tvö þúsundasti")]
        [InlineData(1002000, "ein milljón og tvö þúsundasti")]
        public void ToOrdinalWords(int number, string words, GrammaticalGender gender = GrammaticalGender.Masculine) =>
            Assert.Equal(words, number.ToOrdinalWords(gender));
    }
}
