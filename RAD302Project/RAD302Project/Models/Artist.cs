using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RAD302Project.Models
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }

        [Required]
        public string ArtistName { get; set; }

        [Required]
        public DateTime ActiveFrom { get; set; }

        [Required]
        public Nationality Nationality { get; set; }
    }

    public enum Nationality
    {
        Afghan, Albanian, Algerian, American, Andorran, Angolan, Antiguans, Argentinean, Armenian, Australian, Austrian, Azerbaijani, Bahamian, Bahraini, Bangladeshi,
        Barbadian, Barbudans, Batswana, Belarusian, Belgian, Belizean, Beninese, Bhutanese, Bolivian, Bosnian, Brazilian, British, Bruneian, Bulgarian, Burkinabe, Burmese,
        Burundian, Cambodian, Cameroonian, Canadian, CapeVerdean, CentralAfrican, Chadian, Chilean, Chinese, Colombian, Comoran, Congolese, CostaRican, Croatian, Cuban, Cypriot,
        Czech, Danish, Djibouti, Dominican, Dutch, EastTimorese, Ecuadorean, Egyptian, Emirian, English, EquatorialGuinean, Eritrean, Estonian, Ethiopian, Fijian, Filipino, Finnish,
        French, Gabonese, Gambian, Georgian, German, Ghanaian, Greek, Grenadian, Guatemalan, Guinean, Guyanese, Haitian, Herzegovinian, Honduran, Hungarian,
        Icelander, Indian, Indonesian, Iranian, Iraqi, Irish, Israeli, Italian, Ivorian, Jamaican, Japanese, Jordanian, Kazakhstani, Kenyan, Kuwaiti, Kyrgyz, Laotian,
        Latvian, Lebanese, Liberian, Libyan, Liechtensteiner, Lithuanian, Luxembourger, Macedonian, Malagasy, Malawian, Malaysian, Maldivan, Malian, Maltese, Marshallese,
        Mauritanian, Mauritian, Mexican, Micronesian, Moldovan, Monacan, Mongolian, Moroccan, Mosotho, Motswana, Mozambican, Namibian, Nauruan, Nepalese, Netherlander, NewZealander,
        Nicaraguan, Nigerian, Nigerien, NorthKorean, NorthernIrish, Norwegian, Omani, Pakistani, Palauan, Panamanian, PapuaNewGuinean, Paraguayan, Peruvian, Polish, Portuguese, Qatari,
        Romanian, Russian, Rwandan, SaintLucian, Salvadoran, Samoan, SanMarinese, SaoTomean, Saudi, Scottish, Senegalese, Serbian, Seychellois, SierraLeonean, Singaporean,
        Slovakian, Slovenian, SolomonIslander, Somali, SouthAfrican, SouthKorean, Spanish, SriLankan, Sudanese, Surinamer, Swazi, Swedish, Swiss, Syrian, Taiwanese, Tajik,
        Tanzanian, Thai, Togolese, Tongan, Trinidadian, Tunisian, Turkish, Tuvaluan, Ugandan, Ukrainian, Uruguayan, Uzbekistani, Venezuelan, Vietnamese, Welsh, Yemenite, Zambian, Zimbabwean
    }
}