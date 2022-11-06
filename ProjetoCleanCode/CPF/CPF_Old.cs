using System.Collections.Generic;

namespace ProjetoCleanCode.CPF
{
    public class CPF_Old
    {
        public bool ValidarCPF(string str)
        {
            if (str != null)
            {
                if (!string.IsNullOrEmpty(str))
                {
                    if (str.Length >= 11 || str.Length <= 14)
                    {
                        str = str.Replace(".", "");
                        str = str.Replace(".", "");
                        str = str.Replace("-", "");
                        str = str.Replace(" ", "");

                        char[] digitosCpf = str.ToCharArray();
                        bool equal = true;

                        for (int i = 1; i < digitosCpf.Length - 1; i++)
                        {
                            if (digitosCpf[i] != digitosCpf[0])
                            {
                                equal = false;
                                break;
                            }
                        }                                                   

                        if (!equal)
                        {
                            try
                            {
                                int d1, d2;
                                int dg1, dg2, rest;
                                int digito;
                                string nDigResult;

                                d1 = d2 = 0;
                                dg1 = dg2 = rest = 0;

                                for (var nCount = 1; nCount < str.Length - 1; nCount++)
                                {
                                    // if (isNaN(parseInt(str.substring(nCount -1, nCount)))) {
                                    // 	return false;
                                    // } else {

                                    digito = int.Parse(str.Substring(nCount - 1, nCount));
                                    d1 = d1 + (11 - nCount) * digito;

                                    d2 = d2 + (12 - nCount) * digito;
                                    // }
                                };

                                rest = (d1 % 11);

                                dg1 = (rest < 2) ? dg1 = 0 : 11 - rest;
                                d2 += 2 * dg1;
                                rest = (d2 % 11);
                                if (rest < 2)
                                    dg2 = 0;
                                else
                                    dg2 = 11 - rest;

                                var nDigVerific = str.Substring(str.Length - 2, str.Length);
                                nDigResult = "" + dg1 + "" + dg2;
                                return nDigVerific == nDigResult;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Erro !" + ex);

                                return false;
                            }
                        }
                        else return false;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;
        }
    }
}
