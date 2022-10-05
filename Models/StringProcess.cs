using System.Text.RegularExpressions;
namespace PTPMQL.Models;

public class StringProcess{
    public string RemoveRemainingWhiteSpace (string strInput){
     string str ="";
     strInput= strInput.Trim();
     int index =strInput.IndexOf("  ");
     while(strInput.IndexOf("  ") >0){
        strInput =strInput.Replace("  "," ");
     }
     str = strInput;
     return str; 
    }
    public string LowerToUpper (string strInput){
        string str="";
        strInput=strInput.ToLower();
        str= strInput;
        return str;
    }
    public string UpperToLower (string strInput){
        string str="";
        strInput=strInput.ToUpper();
        str=strInput;
        return str;
    }
    public string CapitalizeOneFirstCharater(string strInput){
        string str="";
        string fistCharater= strInput.Substring(0,1).ToLower();
        str = fistCharater + strInput.Substring(1);
        return str;
    }
    public string CapitalizeFirstCharater (string strInput){
        string str="";
        string[] chuoi = strInput.Split(" ");
        return str;
    }

}