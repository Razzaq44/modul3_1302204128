using System;

public class KodeBuah
{
	public static string getKodeBuah(string kode)
	{
		string[] listNamaBuah = { "Apel", "Aprikot", "Alpukat", "Pisang", "Paprika", "Blackberry", "Ceri", "Kelapa", "Jagung", "Kurma", "Durian", "Anggur", "Melon", "Semangka" };
		string[] listKodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
		int maxNamaBuah = listNamaBuah.Length - 1;

		string namaBuah = "Semangka";
		int kodeBuah = 0;
		while ((namaBuah == "Semangka") && (kodeBuah < maxNamaBuah))
        {
			if ((kode == listKodeBuah[kodeBuah]))
            {
				namaBuah = listNamaBuah[kodeBuah];
            }
			kodeBuah++;
        }
		return namaBuah;
	}
}
