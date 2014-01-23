using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hur_många_versaler.Model
{
    public static class TextaAnalyzer
    {
        public static int GetNumberOfCapitals(string text){

            int uppers = 0;

            for (int i = 0; i < text.Length; i++) {

                if (char.IsUpper(text[i])) {
                    uppers++;
                }
            }
            
            return uppers;
        }

    }
}