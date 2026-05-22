using QuestGameDetective.Domain.Entities;
using QuestGameDetective.Domain.Enums;

namespace QuestGameDetective.Infrastructure.Data.Seed.CaseSeeds
{
    public static class LibraryMurderSeed
    {
        public static readonly Guid CaseId =
            Guid.Parse("11111111-1111-1111-1111-111111111111");

        public static readonly MurderCase Case = new()
        {
            Id = CaseId,

            Title = "Mordet i biblioteket på Kensington Row",


            ShortSummary =
                "Den förmögne affärsmannen Lord Cedric Blackwood hittas död på golvet i sitt privata bibliotek en fredagskväll.",

            Victim = "Sir Cedric Blackwood",

            VictimAge = "69 år",

            VictimJob = "Affärsman - Delägare",

            VictimLifeSituation =
                "Levde i stor villa tillsammans med tjänstefolk och sin brorson. Mycket förmögen. Ogift och utan barn. Enda kvarvarande familj är hans bror och brorsbarn.",

            VictimImg = "victim.png",

            CrimeSceneImg = "crimescene.png",

            CrimeSceneImgText =
                "Brottsplatsfotografi – Biblioteket",

            ClueImg = "housemap.png",

            ClueImgText =
                "Planlösning över fastigheten",

            SecondClueImg = "LibraryMurder-Letter.png",

            SecondClueImgText =
                "Självmordsbrevet som hittades på brottsplatsen",

            CauseOfDeath =
                "En skottskada mot sidan av huvudet. Offret avled omedelbart.",

            Weapon = "Revolver som återfinns på brottsplatsen",

            Place = "Brottet begicks i offrets egen bostad, närmare bestämt i biblioteket.",

            CrimeSceneDescription =
                "Lord Cedric Blackwood påträffades död i sitt privata bibliotek av husets butler omkring halv nio på aftonen. Polisen anlände till herrgården kort därefter.\n" +

                "Den avlidne låg livlös vid sitt skrivbord med en skottskada mot huvudet. Intill offrets högra hand återfanns en revolver, senare identifierad som tillhörande Lord Blackwood själv. (Se brottsplatsfotografi.)\n" +

                "Vapnets hölster återfanns i den översta byrålådan i biblioteket, vilket antyder att revolvern nyligen tagits fram.\n" +

                "Biblioteket uppvisade inga tydliga tecken på strid, inbrott eller annan våldsam oordning. Detsamma gällde övriga delar av bostaden.\n" +

                "På golvet bakom skrivbordet återfanns dessutom ett handskrivet brev, vilket vid första anblick förefaller vara ett självmordsbrev. (Se fotografi — bevismaterial.)\n" +

                "Trots detta framstår flera detaljer på brottsplatsen som märkligt arrangerade, vilket väcker misstanke om att dödsfallet inte är fullt så enkelt som det först verkar.",

            SolutionText =
                "Lord Cedric Blackwood mördades av sin brorson Edmund Blackwood, som under en längre tid dragit på sig betydande skulder och såg sin farbror som sin sista möjlighet till ekonomisk räddning.\n" +

                "Utredningen tog en avgörande vändning när det framkom att Lord Blackwood var vänsterhänt. På både skrivbordet och i övriga delar av biblioteket återfanns personliga föremål konsekvent placerade till vänster om honom.\n" +

                "Trots detta återfanns revolvern intill offrets högra hand, och skottskadan tydde på att vapnet avfyrats från höger sida.\n" +

                "Det handskrivna självmordsbrevet visade dessutom tydliga tecken på att ha skrivits av någon som använt höger hand.\n" +

                "De övriga misstänkta hade alla arbetat eller levt nära Lord Blackwood under många års tid och kände väl till hans vänsterhänthet. Edmund däremot hade endast vistats i huset under en kortare period.\n" +

                "Sammantaget pekar bevisningen mot att brottsplatsen medvetet arrangerats för att efterlikna ett självmord.",

            SolutionClues =

                "• På flera fotografier syns att Lord Blackwood konsekvent använde vänster hand vid skrivande och tedrickande.\n" +

                "• På brottsplatsfotografiet återfanns revolvern placerad nära offrets högra hand trots att offret var vänsterhänt.\n" +

                "• Självmordsbrevet uppvisar tydliga drag av att ha skrivits av en högerhänt person.\n" +

                "• De övriga misstänkta hade känt Lord Blackwood i många år och var väl medvetna om hans vänsterhänthet.\n" +

                "• Edmund Blackwood hade endast vistats i huset under en kortare tid och saknade samma kännedom om offrets vanor.",

            KillerIndex = 1
        };

        public static readonly Suspect[] Suspects =
        {
            new Suspect
            {
                Id = Guid.Parse("aaaaaaaa-1111-1111-1111-111111111111"),

                MurderCaseId = CaseId,

                Name = "Mr. Hargreaves",

                Age = "52 år",

                Job =
                    "Arbetat som butler hela livet, de senaste 24 åren hos Lord Cedric Blackwood",

                LifeSituation =
                    "Aldrig gift, inga barn och bor i ett litet rum på nedervåningen. Enda familjen är en sjuk syster i Brighton.",

                Role = "Offrets butler",

                SuspectImg = "butler.png",

                Statement =
                    "Förhörsrapport:\n" +

                    "\"Jag befann mig i mitt rum på nedre våningen större delen av aftonen, sir. På fredagar brukar jag erhålla några timmars ledighet.\n" +

                    "I vanliga fall hade jag tagit mig en promenad till den lokala puben, men sedan min syster insjuknade går större delen av min lön till hennes uppehälle.\n" +

                    "Hon blev änka tidigare i år, och inte långt därefter stupade hennes ende son i kriget. Nu är hon så svag att hon knappt förmår lämna sin säng.\n" +

                    "Jag hade önskat flytta ned till Brighton för att finna arbete där och ta hand om henne, men Lord Blackwood vägrar låta mig lämna min tjänst.\n" +

                    "Utan ett ordentligt rekommendationsbrev från min arbetsgivare lär ingen vilja anställa mig.\n" +

                    "Men kanske nu… efter alla dessa år i hans tjänst. Kanske kommer min lojalitet äntligen att betyda något.\n" +

                    "Mörda honom? Nej, sir — absolut inte. Lord Blackwood må ha varit en egendomlig herre, men någon ond man var han inte.\n" +

                    "Ja, det var jag som fann honom. Eftersom jag ändå stannade inne den kvällen gick jag upp till biblioteket med en kopp te vid halv åtta.\n" +

                    "Och där låg han redan död.\n" +

                    "Jag hörde inget skott under aftonen, men radion stod på större delen av eftermiddagen. Dessutom är huset mycket väl ljudisolerat.\"",

                InInvestigatorsNotes =
                    "Mr. Hargreaves verkar skakad, men blir märkbart upprörd när samtalet kommer in på hans syster."
            },

            new Suspect
            {
                Id = Guid.Parse("aaaaaaaa-2222-2222-2222-222222222222"),

                MurderCaseId = CaseId,

                Name = "Edmund Blackwood",

                Age = "26 år",

                Job = "Arbetslös",

                LifeSituation =
                    "Blev utslängd av sin far för tre veckor sedan. Hans farbror Lord Cedric Blackwood tog in honom i sitt hem och lät honom bo i gästrummet.",

                Role = "Offrets brorson",

                SuspectImg = "nephew.png",

                Statement =
                    "Förhörsrapport:\n" +

                    "\"Jag tillbringade större delen av aftonen i mitt rum, där jag skrev brev och ordnade vissa personliga angelägenheter.\n" +

                    "Inte för att det egentligen angår er, sir, men jag har flera betydande affärer under uppsegling. Min far, liksom min farfar före honom, var båda framstående män inom affärsvärlden.\n" +

                    "Vem jag skrev till är av privat natur och har inget med denna utredning att göra.\n" +

                    "Att jag skulle ha mördat min farbror är fullständigt befängt. Lord Cedric tog emot mig i sitt hem efter att relationen mellan min far och mig blivit... ansträngd.\n" +

                    "Däremot kan jag inte förneka att både butlern och hushållerskan vid flera tillfällen låtit sin bitterhet över honom komma till uttryck när de trott sig vara ensamma.\n" +

                    "Vad jag själv tror? Självmord.\n" +

                    "Jag råkade överhöra några av polismännen tala om ett brev som påträffats i biblioteket. Ett självmordsbrev, om jag förstod saken rätt.\n" +

                    "Min farbror började bli en gammal man. Hälsan svek honom allt mer för varje månad som gick, och relationerna inom hushållet hade länge varit ansträngda.\n" +

                    "Det är en tragisk historia, sir. Men jag fruktar att hans dalande liv till sist blev för mycket för farbror.\"",

                InInvestigatorsNotes =
                    "Edmund försöker framstå som lugn och hjälpsam men svarar undvikande på frågor om sin ekonomi och de brev han påstår sig ha skrivit."
            },

            new Suspect
            {
                Id = Guid.Parse("aaaaaaaa-3333-3333-3333-333333333333"),

                MurderCaseId = CaseId,

                Name = "Mrs. Beatrice Bloom",

                Age = "61 år",

                Job =
                    "Hushållerska, arbetat hela livet inom hushållstjänst och de senaste 15 åren hos Lord Cedric Blackwood",

                LifeSituation =
                    "Änka, en vuxen dotter. Bosatt i en liten etta ett stenkast från huset.",

                Role = "Offrets hushållerska",

                SuspectImg = "housekeeper.png",

                Statement =
                    "Förhörsrapport:\n" +

                    "\"Jag förstår fortfarande inte varför jag behövde föras hit till polisstationen. Folk kommer börja tala, det är jag övertygad om.\n" +

                    "Ja, Sir Cedric kunde stundtals vara en besvärlig herre att arbeta för, men det betyder inte att jag önskade livet ur honom.\n" +

                    "Jag var förargad över honom de senaste veckorna. Han klagade ständigt på min mat och påstod att den gjorde honom sjuk. Fullständigt trams, om ni frågar mig.\n" +

                    "Något skott hörde jag inte, nej. Men jag får medge att jag inte befann mig i huset under hela aftonen.\n" +

                    "Vid halv sju höll jag på att förbereda kvällsmaten när jag råkade välta en hel kanna lingondricka över mina kläder.\n" +

                    "Så mellan halv sju och åtta befann jag mig hemma för att byta om. Något jag skäms en aning över att behöva erkänna.\n" +

                    "Och om ni frågar mig har det inte varit annat än bekymmer sedan den där slyngeln Edward flyttade in.\n" +

                    "Tidigare under dagen var även Sir Victor Hawthorne där, Lord Blackwoods affärspartner. När jag stod i trappan kunde jag inte undgå att höra hur de grälade i biblioteket.\n" +

                    "Hade jag varit i er sits, sir, hade jag tagit mig ett ordentligt samtal med honom också.\"",

                InInvestigatorsNotes =
                    "Hushållerskan verkar mest irriterad och arg, men samtidigt uppriktig."
            },

            new Suspect
            {
                Id = Guid.Parse("aaaaaaaa-4444-4444-4444-444444444444"),

                MurderCaseId = CaseId,

                Name = "Sir Victor Hawthorne",

                Age = "66 år",

                Job = "Framstående affärsman",

                LifeSituation =
                    "Boende i stor herrgård tillsammans med sin hustru och tjänstefolk. Flera vuxna barn och en handfull barnbarn.",

                Role = "Offrets affärspartner",

                SuspectImg = "workPartner.png",

                Statement =
                    "Polisens anteckningar:\n" +

                    "\"Ja, det stämmer, konstapeln. Jag besökte Cedric tidigare under dagen. Jag tittade förbi på väg hem från arbetet.\n" +

                    "Cedric brukade emellanåt arbeta hemifrån efter lunchtid, och först tänkte jag att den diskussion vi haft tidigare under dagen kunde vänta till efter helgen.\n" +

                    "Men jag ändrade mig under hemvägen. Cedric ville att vi skulle erbjuda arbete åt hans förbaskade brorson, och det hade jag inga som helst intentioner att gå med på.\n" +

                    "Inte nog med att jag tvivlar starkt på att unge Edward någonsin utfört en ärlig dags arbete i hela sitt liv — det hade dessutom skapat problem inom firman.\n" +

                    "Jag har nio barn, konstapeln. Tjugotvå barnbarn, varav åtminstone femton är i arbetsför ålder. Hur hade det sett ut om jag började dela ut tjänster enbart på grund av släktskap?\n" +

                    "Firman hade gått under innan året var slut, och det sade jag också till Cedric.\n" +

                    "När allt väl lagts fram medgav han faktiskt att jag hade en poäng.\n" +

                    "Självmord, säger ni? Nej... det har jag svårt att tro.\n" +

                    "Cedric var sitt vanliga reserverade jag. Något trött kanske, men fullt samlad. Vi skakade hand, sade att vi skulle ses igen på måndag, och därefter gick jag hem.\n" +

                    "Redan före klockan sex var jag tillbaka i mitt eget hus.\"",

                InInvestigatorsNotes =
                    "Affärspartnern framstår som samlad och vältalig, men samtidigt märkbart skakad över sin gamle väns bortgång."
            }
        };
    }
}