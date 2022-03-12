using System;

public class PosisiKarakterGame
{
	enum State { BERDIRI, JONGKOK, TENGKURAP, TERBANG };
	public static void posisiKarakterGame()
	{
		State state = State.BERDIRI;
		string[] screenName = { "BERDIRI", "JONGKOK", "TENGKURAP", "TERBANG" };
		while (state != State.TENGKURAP)
        {
			Console.WriteLine(screenName[(int)state]);
			Console.Write("Enter Command: ");
			string command = Console.ReadLine();
			switch (state)
            {
				case State.BERDIRI:
					if (command == "s")
						state = State.JONGKOK;
					else if (command == "w")
                    {
						state = State.TERBANG;
						Console.WriteLine("Posisi take off");
					}						
					else
						state = State.BERDIRI;
					break;
				case State.JONGKOK:
					if (command == "s")
						state = State.TENGKURAP;
					else if (command == "w")
						state = State.BERDIRI;
					else
						state = State.JONGKOK;
					break;
				case State.TENGKURAP:
					if (command == "w")
						state = State.JONGKOK;
					else
						state = State.TENGKURAP;
					break;
				case State.TERBANG:
					if (command == "x")
                    {
						state = State.JONGKOK;
						Console.WriteLine("posisi landing");
                    }						
					else if (command == "s")                    
						state = State.BERDIRI;										
					else
						state = State.TERBANG;
					break;
			}
        }
		Console.WriteLine("EXIT");
	}
}
