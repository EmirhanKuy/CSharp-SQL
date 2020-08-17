using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CSharpExecQuerySQL
{
    public class DataAccesss
    {
        public DataSet GetData(string theDate1, string theDate2)
        {
            DataSet myDs = new DataSet();
            DataTable myTable = myDs.Tables.Add("Table1");

            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(Connect.ConnectToDatabase(SettingFile.Default.SettingNameSv, SettingFile.Default.SettingNameDb)))
            {
                System.Data.SqlClient.SqlCommand sqlCommand = new System.Data.SqlClient.SqlCommand("dbo.Invoice_GetByDate", connection);
                sqlCommand.Parameters.AddWithValue("@BasTar", theDate1);
                sqlCommand.Parameters.AddWithValue("@BitTar", theDate2);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                System.Data.SqlClient.SqlDataAdapter dataAdapter = new System.Data.SqlClient.SqlDataAdapter();
                dataAdapter.SelectCommand = sqlCommand;
                dataAdapter.Fill(myDs, "Table1");
                return myDs;
            }
        }
    }
}






//using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connect.ConnectToDatabase("ETA_DEMIRCAN_2019")))
       //     {
//var output = connection.Query<SQLData>("dbo.Invoice_GetByDate @BasTar, @BitTar", new { BasTar = year1 + month1 + day1, BitTar = year2 + month2 + day2 }).ToList();
//return output;
      //      }





//Random Query
//var output  = connection.Query<SQLData>($"select * from dbo.FATHAR where FATHARTAR BETWEEN '{ year1 }{ month1 }{ day1 }' AND '{ year2 }{ month2 }{ day2 }'").ToList();


//RealQuery
//var output = connection.Query<SQLData>($"use ETA_DEMIRCAN_2019" +
//    $"                                  IF OBJECT_ID('tempdb..#LISTE1') IS NOT NULL DROP TABLE #LISTE1" +
//    "" +
//    $"                                  SELECT FATHARTIPI AS SUBE, FATHARREFNO AS REFNO, FATHARCARKOD AS CARKOD," +
//    $"                                  CONVERT(varchar, FATHARTAR, 104) AS 'FATURA TAR'," +
//    $"                                  CAST('' AS NVARCHAR(20))  AS 'FATURA NO'," +
//    $"                                  CAST('' AS NVARCHAR(80))  AS 'ÜNVANI'," +
//    $"                                  CAST('' AS NVARCHAR(40))  AS 'T.C.KÝMLÝK'," +
//    $"                                  CAST('' AS NVARCHAR(80))  AS 'KÖYÜ'," +
//    $"                                  FATHARSTKCINS AS 'MALIN CÝNSÝ'," +
//    $"                                  FATHARSTKKOD AS 'MADDE KODU'," +
//    $"                                  FORMAT(SUM(FATHARMIKTAR),'0', 'en-US') AS 'MÝKTARI'," +
//    $"                                  FORMAT((SUM(FATHARTUTAR)/SUM(FATHARMIKTAR)),'N','en-US') AS 'FÝYATI'," +
//    $"                                  CONVERT(NUMERIC(18,2),SUM(FATHARTUTAR)) AS 'TUTAR'," +
//    $"                                  CAST(1 AS numeric)  AS 'Stopaj 0.2'," +
//    $"                                  CAST(0 AS numeric)  AS 'BaðKur 0.2'," +
//    $"                                  CAST(0 AS NUMERIC(18,2)) AS 'Kalan'," +
//    $"                                  CAST(0 AS NUMERIC) AS 'Borsa Tescil 0.4'," +
//    $"                                  CAST(1 AS NUMERIC) AS 'Borsa Tescil 0.2'" +
//    $"                                  INTO #LISTE1 FROM FATHAR" +
//    $"                                  WHERE FATHARTAR BETWEEN '{ year1 }{ month1 }{ day1 }' AND '{ year2 }{ month2 }{ day2 }' " +
//    $"                                  AND FATHARTIPI BETWEEN 5 AND 6 AND FATHARGCFLAG = 1 AND FATHARIPTALFLAG = 0 AND FATHARIADE = 0" +
//    $"                                  GROUP BY FATHARTIPI,FATHARREFNO,FATHARCARKOD,FATHARSTKKOD,FATHARTAR,FATHARSTKCINS" +
//    "" +
//    $"                                  UPDATE A" +
//    $"                                  SET A.[FATURA NO]=B.FATFISEVRAKNO1," +
//    $"                                  A.[ÜNVANI] =B.FATFISCARUNVAN," +
//    $"                                  A.[KÖYÜ]=B.FATFISADRES1," +
//    $"                                  A.Kalan=Convert(numeric(18,2),B.FATFISGENTOPLAM)" +
//    $"                                  FROM #LISTE1 A, FATFIS B" +
//    $"                                  WHERE A.REFNO=B.FATFISREFNO" +
//    "" +
//    $"                                  UPDATE A" +
//    $"                                  SET A.[MADDE KODU]=B.STKCINSI2" +
//    $"                                  FROM #LISTE1 A, STKKART B" +
//    $"                                  WHERE A.[MADDE KODU]= B.STKKOD" +
//    "" +
//    $"                                  UPDATE A" +
//    $"                                  SET A.[T.C.KÝMLÝK]= B.KIMMERNISNO" +
//    $"                                  FROM #LISTE1 A,KIMLIKLER B" +
//    $"                                  WHERE A.CARKOD= B.KIMKOD AND B.KIMITEMNO= 1" +
//    "" +
//    $"                                  UPDATE A" +
//    $"                                  SET A.[Stopaj 0.2]= 0" +
//    $"                                  FROM #LISTE1 A, FATFISTOPLAM B" +
//    $"                                  WHERE A.REFNO= B.FFTREFNO AND B.FFTKONU= 32 AND B.FFTTUTAR= 0" +
//    "" +
//    $"                                  UPDATE A" +
//    $"                                  SET A.[BaðKur 0.2]= 1" +
//    $"                                  FROM #LISTE1 A, FATFISTOPLAM B  " +
//    $"                                  WHERE A.REFNO= B.FFTREFNO AND B.FFTKONU= 31 and B.FFTTUTAR>0" +
//    "" +
//    $"                                  UPDATE A" +
//    $"                                  SET A.[Borsa Tescil 0.4]= 1" +
//    $"                                  FROM #LISTE1 A, FATFISTOPLAM B" +
//    $"                                  WHERE A.REFNO= B.FFTREFNO AND B.FFTKONU= 33 AND B.FFTTUTAR/A.TUTAR>.002" +
//    "" +
//    $"                                  UPDATE A" +
//    $"                                  SET A.[Borsa Tescil 0.2]= 1" +
//    $"                                  FROM #LISTE1 A, FATFISTOPLAM B" +
//    $"                                  WHERE A.REFNO= B.FFTREFNO AND B.FFTKONU= 33 AND B.FFTTUTAR>0" +
//    "" +
//    $"                                  SELECT [SUBE], [FATURA NO], [FATURA TAR], [ÜNVANI], [T.C.KÝMLÝK], [KÖYÜ], [MALIN CÝNSÝ]," +
//    $"                                  [MADDE KODU], [MÝKTARI], [FÝYATI], [TUTAR], [Stopaj 0.2], [BaðKur 0.2], [Kalan], [Borsa Tescil 0.4], [Borsa Tescil 0.2]" +
//    $"                                  from #LISTE1 ORDER BY[SUBE], [MALIN CÝNSÝ], [FATURA NO]").ToList();