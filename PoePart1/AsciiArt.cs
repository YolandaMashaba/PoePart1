﻿using System;

namespace PoePart1
{
    public class AsciiArt
    {
        //Declaration of the logo
        private readonly string logo;//Stores the logo

        public AsciiArt()
        {

            //Define the ASCII art as a string
            logo = @"333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 3333333333333333333333     133333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333337                    3                                                       33333333333333333333 
 3333333333333333   000000000005 00000   000003 500000000000000  0000000000000  00000000000000  3333333333333333333 
 3333333333333333 000007    00000  000000000     0000      0000  10000          0000      80000 3333333333333333333 
 3333333333333333 00003  1           00000   13  0000000000000   100000000000 3 000000000000003 3333333333333333333 
 3333333333333333 00000     00000 31 00000 7333  0000      00000 10000          0000000000002   3333333333333333333 
 3333333333333333  0000000000000  33 00000 3333 3000000000000000 90000000000000 00000     0000573333333333333333333 
 33333333333333333     50004     333 53 74 3333  4                5          5  47 32 331 1  6173333333333333333333 
 33333333333333333333         3333331     733333             7333                    13331     33333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 33333333333333333333333333337           33       333       33333       133               3333333333333333333333333 
 333333333333333333333333333   000000006    00000 333 00000 3333  00000  73 0000000000000 3333333333333333333333333 
 33333333333333333333333333  0000000000000  00000     00000 333  0000000    0000000000000 3333333333333333333333333 
 33333333333333333333333331 00000           00000 111 00000 33  0000  0005      00005     3333333333333333333333333 
 33333333333333333333333331 0000            000000000000000 1  0000    0000  33 00000 33333333333333333333333333333 
 33333333333333333333333333 0000007 5000000 00004     40000   00000000000000  3 00000 33333333333333333333333333333 
 33333333333333333333333333   00000000000   00000 333 00000 00000        000053 00000 33333333333333333333333333333 
 3333333333333333333333333333             3       333             333337      3       33333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 3333333333333333333333333333333333333333333333333333333333333   33333333333333333333333333333333333333333333333333 
 3333333333333333333333333333333333333333331       33333333333 01 3333333333333337          13333333333333333333333 
 333333333333333333333333333333333333333    500000      333333 0       133333333  12698 0003 3333333333333333333333 
 33333333333333333333    333333333333    0006    400000 333333 000000      13333 009000 0009 3333333333333333333333 
 33333333333333333333 00 3333333333   000   00000000000        00000000000       00               33333333333333333 
 33333333333333333333 00 3333333333700   0000000000000000000000000000000000000  00000000000000000633333333333333333 
 33333333333333331    07              00000000000000              000000000000000      90   0     33333333333333333 
 33333333333333337000000000000000  000000000008      800000000009      900000000009    00 1 0 333333333333333333333 
 33333333333333337  05     0    50000000000     000005          500000     0000000009  00 3  7333333333333333333333 
 333333333333333333 00 33 50 337   000009   0000      1333333331      0000   200000000    3333333333333333333333333 
 333333333333333333 00 331   3333    0  2000     33333333333333333333     0002  00000000  3333333333333333333333333 
 333333333333333333 00 7      73   00 008    3333333333333333333333333333    000 80000000  133333333333333333333333 
 333333333333333333 00  00  0    003 00  733333333333333333333333333333333337  00  0000000  33333333333333333333333 
 333333333333333333    30  0000000   00 33333333333333333333333333333333333333 00   0000000  3333333333333333333333 
 33333333333333333333  0  0000000  3 00 33333333333333333333333333333333333333 00 3  0000000  333333333333333333333 
 33333333333333333337 00 0000000  33 00 333333333333333        133333333333333 00 33  0000000 733333333333333333333 
 3333333333333333333  0  000000  333 00 3333333333333   000000   3333333333333 00 333  000000  33333333333333333333 
 3333333333333333333 00 0000005 1333 00 3333333333331 0000000000 3333333333333 00 3331 5000000 73333333333333333333 
 3333333333333333337    000000  3333 00 3333333333337 0000000000 7333333333333 00 3333  000000  3333333333333333333 
 333333333333333333 80 0000004 33333 00 3333333333337 0000000000 7333333333333 00 33333 4000008 3333333333333333333 
 333333333333333333 00 000000  33333 00 3333333333331 0000000000 1333333333333 00 33333  000000 3333333333333333333 
 333333333333333333 00 000000  33333 00 3333333333333   000000   3333333333333 00 33333  000000 3333333333333333333 
 333333333333333333 00 000000  33333 00 333333333333337 000000  33333333333333 00 33333  000000 3333333333333333333 
 333333333333333333    000000  33333 00 33333333333333  000000  33333333333333 00 33333  000000 3333333333333333333 
 333333333333333333333 000000  33333 00 33333333333333  000000  33333333333333 00 33333  000000 3333333333333333333 
 333333333333333333333 8000006 33333 00 33333333333333 00000000 33333333333333 00 33333 0000009 3333333333333333333 
 333333333333333333333  000000  3333 00 3333333333333  00000000  3333333333333 00 3333  0 00005 3333333333333333333 
 3333333333333333333337 0000000 1333 00 3333333333333 0000000008 3333333333333 00 3331 00      73333333333333333333 
 3333333333333333333333  000000  333 50  333333333333 0000000000 333333333333  02 333  0  3333333333333333333333333 
 33333333333333333333337 0000000  33  00  33333333333 0000000000 33333333333  00 733  0   3333333333333333333333333 
 33333333333333333333333  0000000  33  00  3333333333            3333333333  00  33  00 053333333333333333333333333 
 333333333333333331   333  0000000  73  00   3333333333333333333333333333   00  3   0  09 3333333333333333333333333 
 33333333333333337  0  333  0009  09  3  300  73333333333333333333333337  003  3  800 0  73   333333333333333333333 
 3333333333333333 000023333  00    00   7  000   33333333333333333333   000  7   00 00   33 0 333333333333333333333 
 3333333333333333      33333  007    00      000    33333333333333    000      000    00    0  13333333333333333333 
 33333333333333333  0 7333333   0 31   00       000    33333333    000       0000000   3003 0 563333333333333333333 
 33333333333333333  0                    000       000          0001      000000000000   38555001333333333333333333 
 33333333333333333 700000000000000000000000000 331    0000990000      700000000000   00         1333333333333333333 
 333333333333333331       0   0                           1      900000000000000  000  00         33333333333333333 
 33333333333333333333333 30 3 00 333333 0000  000009    3 0000000000000000000   000     000000000333333333333333333 
 33333333333333333333333 30 3    3333337    0000    805   0000000000000005   000   7333 00 05     33333333333333333 
 33333333333333333333333 30 733333333333333     20000000  00000000002    0000    333333 00 00 333333333333333333333 
 3333333333333333333333  20  3333333333333333331          00          13      333333333    00 333333333333333333333 
 3333333333333333333333 0000 3333333333333333333333333333 00000000733333333333333333333333    333333333333333333333 
 3333333333333333333333      3333333333333333333333333333 00       333333333333333333333333333333333333333333333333 
 33333333333333333333333377133333333333333333333333333333 89 333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333331  1333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 
 333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333 ";
        }

        //Method to display the ASCII art
        public void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;//Set text color to Magenta
            Console.WriteLine(logo);//Print the ASCII art
            Console.ResetColor();//Reset to default color
        }


    }


}
