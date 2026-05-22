using QuestGameDetective.Domain.Entities;

namespace QuestGameDetective.Infrastructure.Data.Seed.CaseSeeds
{
    public static class NightTrainMurderSeed
    {
        public static readonly Guid CaseId =
            Guid.Parse("22222222-2222-2222-2222-222222222222");

        public static readonly MurderCase Case = new()
        {
            Id = CaseId,

            Title = "Mysteriet på nattåget till Edinburgh",

            ShortSummary =
                "En man återfinns död i en låst förstaklasskupé under nattresan mellan London och Edinburgh.",

            Victim = "Arthur Miller",

            VictimAge = "43 år",

            VictimJob = "Butiksbiträde i bokhandel",

            VictimLifeSituation =
                "Levde ensam i en mindre enrummare utanför London. Hade få nära relationer och mycket begränsad ekonomi.",

            VictimImg = "victim_train.png",

            CrimeSceneImg = "traincrime.png",

            CrimeSceneImgText =
                "Brottsplatsfotografi – Förstaklasskupén",

            ClueImg = "trainbag.png",

            ClueImgText =
                "Innehållet i offrets väska",

            SecondClueImg = "doctorLetter.png",

            SecondClueImgText =
                "Medicinsk handling hittas på offrets köksbord",

            Place =
                "Brottet ägde rum ombord på nattåget mellan London och Edinburgh, i en låst förstaklasskupé.",

            CauseOfDeath =
                "Andningsstillestånd orsakat av en kraftig överdos av morfinbaserat smärtstillande medel.",

            Weapon =
                "Medicinsk injektionsspruta återfunnen under offrets säte.",

            CrimeSceneDescription =
                "Arthur Miller påträffades död strax före gryningen av konduktören under nattågets färd mot Edinburgh.\n\n" +

                "Kupédörren hade varit låst från insidan större delen av natten och inga vittnen hade sett någon lämna eller beträda kupén efter att tåget lämnat London.\n\n" +

                "Endast tre andra personer befann sig i förstaklasskupén under resan: Lady Eleanor Whitmore, hennes tjänsteflicka Clara Bennett samt den pensionerade handelsmannen Harold Finch.\n\n" +

                "Offret satt tillbakalutad i sin sittplats och såg vid första anblick ut att ha somnat. Först när konduktören försökte väcka mannen upptäcktes att han var avliden.\n\n" +

                "En mindre injektionsspruta återfanns senare under offrets säte. På offrets högra arm kunde dessutom ett mindre stickmärke observeras.\n\n" +

                "Trots den ovanliga situationen återfanns inga tydliga tecken på kamp eller våld inne i kupén.\n\n" +

                "Flera passagerare uppgav däremot att offret under kvällen luktat kraftigt av alkohol och verkat ovanligt avslappnad trots sin enkla klädsel och det dyra resesällskapet.",

            SolutionText =
                "Arthur Miller mördades inte av någon av de övriga passagerarna. Mannen tog sitt eget liv någon gång under natten.\n\n" +

                "Utredningen tog en avgörande vändning när polisens läkare kunde koppla den återfunna sprutan till ett kraftigt morfinbaserat läkemedel.\n\n" +

                "Vid vidare undersökning framkom att Arthur Miller endast två veckor tidigare diagnostiserats med en dödlig sjukdom och enligt läkarna hade mycket kort tid kvar att leva.\n\n" +

                "I offrets bagage återfanns både medicinska dokument och smärtstillande preparat utskrivna i hans eget namn.\n\n" +

                "Arthur Miller var dessutom känd av sin arbetsgivare som en stor beundrare av kriminalromaner och verkliga mordutredningar.\n\n" +

                "Polisen drog därför slutsatsen att mannen medvetet iscensatt sin egen död som ett till synes omöjligt mord ombord på nattåget.\n\n" +

                "Efter att de övriga passagerarna somnat injicerade han själv läkemedlet, dolde sprutan under sätet och inväntade därefter döden.",

            SolutionClues =

            "• En medicinsk spruta återfanns på golvet intill offret.\n\n" +

            "• Ett läkarintyg återfanns bland offrets tillhörigheter som visade att han led av obotlig cancer.\n\n" +

            "• Offret reste ensam i en förstaklasskupé trots att han vid första anblick verkade vara en man med mycket begränsade tillgångar.\n\n" +

            "• På fotografiet av offrets resväska syns endast ett fåtal ägodelar: en dyr flaska whisky, flera kriminalromaner, mediciner samt ett mycket litet antal mynt.\n\n" +

            "• Väskan var ovanligt sparsamt packad för en längre resa.",

            KillerIndex = 4
        };

        public static readonly Suspect[] Suspects =
        {
            new Suspect
            {
                Id = Guid.Parse("bbbbbbbb-1111-1111-1111-111111111111"),

                MurderCaseId = CaseId,

                Name = "Lady Eleanor Whitmore",

                Age = "58 år",

                Job = "Överklassdam",

                LifeSituation =
                    "Tillhör en gammal aristokratisk familj och reser regelbundet mellan London och Edinburgh för att besöka släktingar.",

                Role = "Passagerare i kupén",

                SuspectImg = "trainlady.png",

                Statement =
                    "Förhörsrapport:\n\n" +

                    "\"Jag reste till Edinburgh för att besöka min syster. Hennes makes bortgång tidigare under året har tagit mycket hårt på henne.\n\n" +

                    "Sova sittandes på ett tåg? Nej, konstapeln. Sådant må andra människor ägna sig åt. Jag vilade möjligen ögonen en stund.\n\n" +

                    "Den döde mannen hade jag aldrig tidigare sett.\n\n" +

                    "Jag måste dock medge att jag fann det märkligt att en så enkelt klädd person reste i förstaklass.\n\n" +

                    "När jag var ung hade människor en betydligt bättre förståelse för sin plats i samhället.\"",

                InInvestigatorsNotes =
                    "Lady Eleanor uppträder kyligt och kontrollerat men verkar genuint obekväm av hela situationen."
            },

            new Suspect
            {
                Id = Guid.Parse("bbbbbbbb-2222-2222-2222-222222222222"),

                MurderCaseId = CaseId,

                Name = "Clara Bennett",

                Age = "21 år",

                Job = "Tjänsteflicka",

                LifeSituation =
                    "Arbetar sedan ett år tillbaka åt Lady Eleanor Whitmore. Kommer ursprungligen från Brighton.",

                Role = "Lady Eleanors tjänsteflicka",

                SuspectImg = "trainmaid.png",

                Statement =
                    "Förhörsrapport:\n\n" +

                    "\"Jag har arbetat hos Lady Eleanor i ungefär ett år nu.\n\n" +

                    "Innan dess tjänade jag hos en familj i Brighton.\n\n" +

                    "Jag talade aldrig med den döde mannen. Han läste mest under resan och verkade hålla sig för sig själv.\n\n" +

                    "Lady Eleanor sade åt mig att försöka sova eftersom vi hade en lång resa framför oss.\n\n" +

                    "Jag tror faktiskt att hennes nåd somnade före mig. Hon snarkar lite ibland, förstår ni.\"",

                InInvestigatorsNotes =
                    "Clara verkar nervös men hennes berättelse förblir konsekvent under förhöret."
            },

            new Suspect
            {
                Id = Guid.Parse("bbbbbbbb-3333-3333-3333-333333333333"),

                MurderCaseId = CaseId,

                Name = "Harold Finch",

                Age = "71 år",

                Job = "Pensionerad handelsman",

                LifeSituation =
                    "Änkeman och pensionerad köpman. Bor ensam i utkanten av Edinburgh.",

                Role = "Passagerare i kupén",

                SuspectImg = "oldman.png",

                Statement =
                    "Förhörsrapport:\n\n" +

                    "\"Va? Ni får tala högre, konstapeln. Hörseln är inte vad den en gång var.\n\n" +

                    "Jag sov större delen av resan, precis som jag alltid gör på tåg.\n\n" +

                    "Oberörd? Nej då, men när man nått min ålder är det inte mycket som längre förvånar en.\n\n" +

                    "Jag har överlevt två krig och fyrtio års äktenskap. Då lär man sig hålla huvudet kallt.\n\n" +

                    "I London besökte jag en gammal vän från ungdomens dagar. Vi gick i skolan tillsammans.\n\n" +

                    "Nej, jag kände inte den döde mannen och knappt någon av de andra passagerarna heller.\"",

                InInvestigatorsNotes =
                    "Harold Finch framstår som ovanligt lugn men hans berättelse innehåller inga tydliga motsägelser."
            },

       new Suspect
    {
        Id = Guid.Parse("bbbbbbbb-4444-4444-4444-444444444444"),

        MurderCaseId = CaseId,

        Name = "Dr. Charles Mortimer",

        Age = "31 år",

        Job = "Läkare",

        LifeSituation =
            "Gift och far till tre barn. Har praktiserat som läkare i sju år. Känd som ordningsam och har aldrig tidigare varit i kontakt med polisen.",

        Role = "Offrets läkare",

        SuspectImg = "doctor.png",

        Statement =
            "Förhörsrapport:\n\n" +

            "\"Ja, det stämmer, konstapeln. Jag var Arthur Millers läkare, även om jag inte behandlat honom särskilt länge.\n\n" +

            "Mr Miller sökte först vård för återkommande buksmärtor. Efter mina inledande undersökningar remitterade jag honom vidare till en specialistklinik i London.\n\n" +

            "Det visade sig dessvärre att han led av långt framskriden cancer.\n\n" +

            "Sjukdomen hade redan gått mycket långt och läkarna gav honom endast en kort tid kvar att leva.\n\n" +

            "Ja, jag skrev ut både smärtstillande tabletter och morfininjektioner för att hjälpa honom hantera smärtorna.\n\n" +

            "Men jag försäkrar er, konstapeln, att all medicinering skedde helt enligt medicinska rekommendationer för patienter i hans tillstånd.\n\n" +

            "Det är en fruktansvärd tragedi alltihop.\n\n" +

            "Mr Miller verkade visserligen nedstämd vid vårt senaste möte, men jag hade aldrig kunnat föreställa mig något sådant här.\"",

        InInvestigatorsNotes =
            "Dr. Charles Mortimer framstår som uppriktigt förfärad över vad som inträffat. Under förhöret uppträder han nervöst men samarbetsvilligt och inga tydliga motsägelser framkommer."
    }

            };
    }
}
