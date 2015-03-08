using UnityEngine;
using System.Collections;

public class TextBoxContent : MonoBehaviour
{
    public string[][] dialogies;
    public string[] beginning;
    public string[] fireStarts;
    public string[] movingToEteinen;
    public string[] movingToYard;
    public string[] movingToKatos;
    public string[] toTapaamispaikka;

	// Use this for initialization
	private void Awake ()
    {
        SetUpBeginning();
        SetUpFireStarts();
        SetUpMovingToEteinen();
        SetUpMovingToYard();
        SetUpMovingToKatos();
        SetUpToTapaamispaikka();
        SetUpDialogies();

        //Debug.Log(dialogies[0].Length + " dialogies lenght");
	}

    private void SetUpDialogies()
    {
        dialogies = new string[6][];

        dialogies[0] = beginning;
        dialogies[1] = fireStarts;
        dialogies[2] = movingToEteinen;
        dialogies[3] = movingToYard;
        dialogies[4] = movingToKatos;
        dialogies[5] = toTapaamispaikka;
    }

    private void SetUpBeginning()
    {
        beginning = new string[] // tämä ei tällä hetkellä ole käytössä, sisältö seuraavassa taulukossa
        {
            "Olipa kerran Kanimaa, jossa asusti pieni pupupoika nimeltään Sepi.",
            "Sepi oli viisivuotias ja kävi Kanimaan Päiväkodissa silloin, kun hänen pupuvanhempansa olivat töissä.",
            "Kanimaan päiväkodissa Sepillä oli paljon ystäviä, joiden kanssa hän leikki hippaa ja muita leikkejä.",
            "Loppu."
        };
    }

    private void SetUpFireStarts()
    {
        fireStarts = new string[]
        {            
            "Olipa kerran Kanimaa, jossa asusti pieni pupupoika nimeltään Sepi.",
            "Sepi oli viisivuotias ja kävi Kanimaan Päiväkodissa silloin, kun hänen pupuvanhempansa olivat töissä.",
            "Kanimaan päiväkodissa Sepillä oli paljon ystäviä, joiden kanssa hän leikki hippaa ja muita leikkejä.",
            "Eräänä päivänä lounaalla sattui kuitenkin kummia.",
            "Sepi ja hänen ystävänsä söivät ruokailuhuoneessa pöydän ääressä, kun keittiöstä alkoi leijailla outo haju.",
            "Pian huoneeseen alkoi tupruamaan savua.",
            "Eräs hoitotädeistä korotti äänensä:",
            "“Kuulkaa kaikki pikkupuput! Nyt jokaisen on lopetettava syöminen ja noustava ylös.”",
            "Sepi haluaisi kuunnella tarhatätiä, mutta tänään on tarjolla hänen lempiruokaansa, porkkanaa ja salaatinlehtiä.",
            "Mitä Sepin pitäisi mielestäsi tehdä?",
            "Loppu."
        };
    }
    //      
    private void SetUpMovingToEteinen()
    {
        movingToEteinen = new string[]
        {
            "Sepi nousi ylös ja odotti lisää ohjeita.",
            "Täti varmisti, että kaikki pikkupuput olivat lopettaneet syömisen ja nousseet ylös pöydistään.",
            "Tämän jälkeen hän sanoi:",
            "“Voisivatko kaikki siirtyä nyt rauhallisesti eteiseen päin?“",
            "Sepi mietti, mitä hän tekisi. Tätiä pitäisi kuunnella, mutta Sepi halusi tietää, mikä keittiössä savusi.",
            "Mitä Sepin tulisi tehdä?",
            "Loppu."
        };
    }
    //        Täti puhui taas:   
    private void SetUpMovingToYard()
    {
        movingToYard = new string[]
        {
            "Sepi seurasi muita tarhakavereitaan eteiseen.",
            "Savu alkoi leviämään jo sinnekin.",
            "Kun kaikki puput olivat eteisessä, ruokailuhuoneen ovi laitettiin kiinni.",
            "Näin savun eteneminen estettiin.",
            "Täti korotti taas ääntään:",
            "“Voisivatko kaikki kuunnella minua? Meidän on nyt siirryttävä ulos odottamaan palomiehiä.”",
            "Sepi joutui hetken miettimään, mitä ne palomiehet taas olivatkaan.",
            "Pian hän muistikin. Palomiehet ovat urheita pupuja, jotka sammuttavat tulipaloja.",
            "Täti puhui taas:",
            "“Kaikkien on nyt laitettava kengät jalkaan ja mentävä leikkikentän laidalle.",
            "Siellä on meidän tapaamispaikkamme, jos on tällainen tilanne.”",
            "Sepi oli jo kurottamassa kenkiinsä, kun hän muisti, että hänen puseronsa oli unohtunut ruokailuhuoneeseen.",
            "Mitä hän nyt tekisi?",
            "Loppu."
        };
    }
    //      
    private void SetUpMovingToKatos()
    {
        movingToKatos = new string[]
        {
            "Sepi puki kengät nopeasti jalkoihinsa ja kiiruhti ulos.",
            "Puseron olisi nyt jäätävä ruokailuhuoneeseen.",
            "Ulkona Sepi näki leikkikentän.",
            "Heidän piti mennä tapaamispaikalle, joka sijaitsi kentän laidalla, mutta Sepi haluaisi myös käydä liukumäessä nopeasti.",
            "Eihän siitä mitään haittaa olisi.",
            "Mitä Sepin pitäisi mielestäsi tehdä?",
            "Loppu."
        };
    }
    //         Loppu.
    private void SetUpToTapaamispaikka()
    {
        toTapaamispaikka = new string[]
        {
            "Sepi voitti kiusauksen.",
            "Hän ei mennyt liukumäelle vaan kentän laidalle muiden kanssa.",
            "Sepi voisi leikkiä myöhemminkin.",
            "Nyt pitää kuunnella aikuisia.",
            "Pian kaikki Kanimaan Päiväkodin pikkupuput ja hoitotädit olivat turvallisesti kentän laidalla.",
            "Pian päiväkodin pihaan kurvasi iso punainen paloauto.",
            "Paloauton sisällä oli rohkean näköisiä palomiehiä.",
            "Pian he olivat sammuttaneet tulen.",
            "Kaikki oli taas hyvin.",
            "Sen pituinen se.",
            "Loppu."
        };
    }
}