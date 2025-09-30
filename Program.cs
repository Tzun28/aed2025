using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        Dictionary<char, Dictionary<char, Dictionary<char, string>>> Aminoacidos = new Dictionary<char, Dictionary<char, Dictionary<char, string>>>
        {
            ['U'] = new Dictionary<char, Dictionary<char, string>>
            {
                ['U'] = new Dictionary<char, string>
                {
                    ['U'] = "Fenilalanina",
                    ['C'] = "Fenilalanina",
                    ['A'] = "Leucina",
                    ['G'] = "Leucina"
                },
                ['C'] = new Dictionary<char, string>
                {
                    ['U'] = "Serina",
                    ['C'] = "Serina",
                    ['A'] = "Serina",
                    ['G'] = "Serina"
                },
                ['A'] = new Dictionary<char, string>
                {
                    ['U'] = "Tirosina",
                    ['C'] = "Tirosina",
                    ['A'] = "Parada",
                    ['G'] = "Parada"
                },
                ['G'] = new Dictionary<char, string>
                {
                    ['U'] = "Cisteína",
                    ['C'] = "Cisteína",
                    ['A'] = "Parada",
                    ['G'] = "Triptofano"
                }
            },
            ['C'] = new Dictionary<char, Dictionary<char, string>>
            {
                ['U'] = new Dictionary<char, string>
                {
                    ['U'] = "Leucina",
                    ['C'] = "Leucina",
                    ['A'] = "Leucina",
                    ['G'] = "Leucina"
                },
                ['C'] = new Dictionary<char, string>
                {
                    ['U'] = "Prolina",
                    ['C'] = "Prolina",
                    ['A'] = "Prolina",
                    ['G'] = "Prolina"
                },
                ['A'] = new Dictionary<char, string>
                {
                    ['U'] = "Hidistina",
                    ['C'] = "Hidistina",
                    ['A'] = "Glutamina",
                    ['G'] = "Glutamina"
                },
                ['G'] = new Dictionary<char, string>
                {
                    ['U'] = "Arginina",
                    ['C'] = "Arginina",
                    ['A'] = "Arginina",
                    ['G'] = "Arginina"
                }
            },
            ['A'] = new Dictionary<char, Dictionary<char, string>>
            {
                ['U'] = new Dictionary<char, string>
                {
                    ['U'] = "Isoleucina",
                    ['C'] = "Isoleucina",
                    ['A'] = "Isoleucina",
                    ['G'] = "Metionina"
                },
                ['C'] = new Dictionary<char, string>
                {
                    ['U'] = "Treonina",
                    ['C'] = "Treonina",
                    ['A'] = "Treonina",
                    ['G'] = "Treonina"
                },
                ['A'] = new Dictionary<char, string>
                {
                    ['U'] = "Asparagina",
                    ['C'] = "Asparagina",
                    ['A'] = "Lisina",
                    ['G'] = "Lisina"
                },
                ['G'] = new Dictionary<char, string>
                {
                    ['U'] = "Serina",
                    ['C'] = "Serina",
                    ['A'] = "Arginina",
                    ['G'] = "Arginina"
                }
            },
            ['G'] = new Dictionary<char, Dictionary<char, string>>
            {
                ['U'] = new Dictionary<char, string>
                {
                    ['U'] = "Valina",
                    ['C'] = "Valina",
                    ['A'] = "Valina",
                    ['G'] = "Valina"
                },
                ['C'] = new Dictionary<char, string>
                {
                    ['U'] = "Alanina",
                    ['C'] = "Alanina",
                    ['A'] = "Alanina",
                    ['G'] = "Alanina"
                },
                ['A'] = new Dictionary<char, string>
                {
                    ['U'] = "Aspartato",
                    ['C'] = "Aspartato",
                    ['A'] = "Glutamato",
                    ['G'] = "Glutamato"
                },
                ['G'] = new Dictionary<char, string>
                {
                    ['U'] = "Glicina",
                    ['C'] = "Glicina",
                    ['A'] = "Glicina",
                    ['G'] = "Glicina"
                }
            }

        };
    Console.WriteLine("Digite a trinca de nucleotídeos");
        
    }
        
        
    }
}