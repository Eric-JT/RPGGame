using System;

namespace RPGGame
{
    class Figthing
    {
        public void Fight()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("|You enconter a monster                                                     |");
            Console.WriteLine("|                                     HP = {0}                              |", Enemy.iHealth);
            Console.WriteLine("|                                       _____                               |");
            Console.WriteLine("|                                  ___ |     |___                           |");
            Console.WriteLine("|                                  `-._)    (_, -`                          |");
            Console.WriteLine("|                                      |O _ O/                              |");
            Console.WriteLine("|                                       | - /                               |");
            Console.WriteLine("|                                        `-(                                |");
            Console.WriteLine("|                                         ||                                |");
            Console.WriteLine("|                                       _ || _                              |");
            Console.WriteLine("|                                       | -..-|                             |");
            Console.WriteLine("|                                       ||. | |                             |");
            Console.WriteLine("|                                       ||__ ||                             |");
            Console.WriteLine("|                                      . |//\\|_,                            |");
            Console.WriteLine("|                                     `-((  )) - '                          |");
            Console.WriteLine("|                                       __\\//__                             |");
            Console.WriteLine("|                                     > _ /| _ <,                           |");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|  (1) Attack                                                               |");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|                                HP = {0}                                   |", Player.iHealth);
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.ResetColor();
        }

        public void Fight2()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("|You enconter a monster                                                     |");
            Console.WriteLine("|                                         HP = {0}                          |", Enemy.iHealth);
            Console.WriteLine("|                                          .--.    | V |                    |");
            Console.WriteLine("|                                         /    |   |  /                     |");
            Console.WriteLine("|                                         q ..  p  | /                      |");
            Console.WriteLine("|                                          |--/   //                        |");
            Console.WriteLine("|                                         _ | | __//                        |");
            Console.WriteLine("|                                        /.    _ /                          |");
            Console.WriteLine("|                                       // |  /                             |");
            Console.WriteLine("|                                      //   ||                              |");
            Console.WriteLine("|                                       \\  /  |                             |");
            Console.WriteLine("|                                       )||    |                            |");
            Console.WriteLine("|                                      / || || |                            |");
            Console.WriteLine("|                                      |/|| || |                            |");
            Console.WriteLine("|                                         | || |                            |");
            Console.WriteLine("|                                         | || /                            |");
            Console.WriteLine("|                                      __ / || |__                          |");
            Console.WriteLine("|                                    |____ /|____/                          |");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|  (1) Attack                                                               |");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|                                HP = {0}                                   |", Player.iHealth);
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.ResetColor();
        }

        public void Fight3()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("|You enconter a monster                                                     |");
            Console.WriteLine("|                                       HP = {0}                            |", Enemy.iHealth);
            Console.WriteLine("|                                 /                  /                      |");
            Console.WriteLine("|                        _________))                ((__________            |");
            Console.WriteLine("|                      /.------ -./\\    /    /    ///.--------./            |");
            Console.WriteLine("|                      //#######//##\\   ))  ((   //##\\########\\             |");
            Console.WriteLine("|                     //#######//###((  ((    ))  ))###\\########\\           |");
            Console.WriteLine("|                    ((#######((#####\\  \\  //  //#####))########))          |");
            Console.WriteLine("|                     |##' `###|######\\  |)(/  //######/####' `##/          |");
            Console.WriteLine("|                      )'    ``#)'  `##|`->oo<-'/##'  `(#''     `(          |");
            Console.WriteLine("|                              (       ``|`..'/''       )                   |");
            Console.WriteLine("|                                         |''|                              |");
            Console.WriteLine("|                                         `- )                              |");
            Console.WriteLine("|                                         / /                               |");
            Console.WriteLine("|                                        ( /                                |");
            Console.WriteLine("|                                        | |                                |");
            Console.WriteLine("|                                        | |                                |");
            Console.WriteLine("|                                         V                                 |");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|  (1) Attack                                                               |");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|                                HP = {0}                                   |", Player.iHealth);
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.ResetColor();
        }

        public void Boss()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("|You Found the dungeon master                                                |");
            Console.WriteLine("|                              HP = {0}                                      |", Enemy.iHealth);
            Console.WriteLine("|                         ` -._                                              |");
            Console.WriteLine("|                           `.  -._                                          |");
            Console.WriteLine("|                             T.    -.                                       |");
            Console.WriteLine("|                              $$p.    -.                                    |");
            Console.WriteLine("|                              $$$$b.    `,                                  |");
            Console.WriteLine("|                           .g$$$$$$$b    ;                                  |");
            Console.WriteLine("|                         .d$$$$$$$$$$;   ;                                  |");
            Console.WriteLine("|                      __d$$$$$$P^T$$     :                                  |");
            Console.WriteLine("|                    .d$$$$P^^___        :                                   |");
            Console.WriteLine("|                   d$P'__..gg$$$$$$$$$$; ;                                  |");
            Console.WriteLine("|  	           d$$ :$$$$$$$$$$$$$$$$; ;                                  |");
            Console.WriteLine("|                 :$$; $$$$$$$$$$$$$$$$P:$                                   |");
            Console.WriteLine("|                 $$$  $$$$$$$$$$$$$$$$b  $$                                 |");
            Console.WriteLine("|                :$$$ :$$$$$$$$$$$$$$$$$; $$;                                |");
            Console.WriteLine("|                $$$; $$$$$$$$$$$$$$$$$$; $$;                                |");
            Console.WriteLine("|               :$$$  $$$$$$$$$^$$$$$$$$$ :$$                                |");
            Console.WriteLine("|               $$$; :$$$p__gP' `Tp__g$$$ :$$                                |");
            Console.WriteLine("|              :$$$  $$P`T$P' .$. `T$P'T$; $$;                               |");
            Console.WriteLine("|              $$$; :$$;     :P ^ T;   :$; $$;                               |");
            Console.WriteLine("|             :$$$  $$$$-.           .-$$$ :$$                               |");
            Console.WriteLine("|             $$$$ :$$$$; |   T$P   / :$$$  $$                               |");
            Console.WriteLine("|            :$$$; $$$$$$  ; b:$;d :  $$$$; $$;                              |");
            Console.WriteLine("|            $$$$; $$$$$$; : T T T ; :$$$$$ :$$                              |");
            Console.WriteLine("|         .g$$$$$  :$$$$$$  ;' | ':  $$$$$$  T$b                             |");
            Console.WriteLine("|      .g$$$$$$$$   $$$$$$b :     ; d$$$$$;   `Tb                            |");
            Console.WriteLine("|     :$$$$$$$$$;   :$$$$$$$;     :$$$$$$P       |                           |");
            Console.WriteLine("|     :$$$$$$$$$;    T$$$$$$$p._.g$$$$$$P         ;                          |");
            Console.WriteLine("|     $$$P^^T$$$$p.   `T$$$$$$$$$$$$$$P'     _/`. :                          |");
            Console.WriteLine("|            `T$$$$$b.  `T$$$$$$$$$$P'    .g$P   |;                          |");
            Console.WriteLine("|              `T$$$$$b.   ^ T$$$$P ^        d$P'                            |");
            Console.WriteLine("|                `T$$$$$b.             .dP'                                  |");
            Console.WriteLine("|                   ^ T$$$$b.        .g$P'                                   |");
            Console.WriteLine("|                      ^ T$$$b.g$P ^                                         |");
            Console.WriteLine("|                         ^ T$b.g$P ^                                        |");
            Console.WriteLine("|                            ^$^                                             |");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|  (1) Attack                                                               |");
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("|                                HP = {0}                                   |", Player.iHealth);
            Console.WriteLine("|                                                                           |");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.ResetColor();

        }

    }
}


