using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace XamarinPlugins
{
    class Morse
    {
        private Dictionary<char, string> Mapping = new Dictionary<char, string>
        {
            {'A',"kl" },
            {'B',"lkkk" },
            {'C',"lklk" },
            {'D',"lkk" },
            {'E',"k" },
            {'F',"kklk" },
            {'G',"llk" },
            {'H',"kkkk" },
            {'I',"kk" },
            {'J',"klll" },
            {'K',"lkl" },
            {'L',"klkk" },
            {'M',"ll" },
            {'N',"lk" },
            {'O',"lll" },
            {'P',"kllk" },
            {'Q',"llkl" },
            {'R',"klk" },
            {'S',"kkk" },
            {'T',"l" },
            {'U',"kkl" },
            {'V',"kkkl" },
            {'W',"kll" },
            {'X',"lkkl" },
            {'Y',"lkll" },
            {'Z',"llkk" },
            {'1',"kllll" },
            {'2',"kklll" },
            {'3',"kkkll" },
            {'4',"kkkkl" },
            {'5',"kkkkk" },
            {'6',"lkkkk" },
            {'7',"llkkk" },
            {'8',"lllkk" },
            {'9',"llllk" },
            {'0',"lllll" },
        };
        private const int unit = 250;
        private async Task Lang()
        {
            await Flashlight.TurnOnAsync();
            await Task.Delay(unit * 3);
            await Flashlight.TurnOffAsync();
        }
        private async Task Kurz()
        {
            await Flashlight.TurnOnAsync();
            await Task.Delay(unit * 1);
            await Flashlight.TurnOffAsync();
        }
        private async Task ZeichenPause()
        {
            await Task.Delay(unit * 3);
        }
        private async Task WortPause()
        {
            await Task.Delay(unit * 7);
        }

        public async Task MorseAusgeben(string eingabe)
        {
            foreach (char zeichen in eingabe)
            {
                if (Mapping.ContainsKey(char.ToUpper(zeichen)))
                {
                    foreach (char Signal in Mapping[char.ToUpper(zeichen)])
                    {
                        if (Signal == 'k')
                            await Kurz();
                        else
                            await Lang();
                        await ZeichenPause();
                    }
                }
                else if (string.IsNullOrWhiteSpace(zeichen.ToString()))
                {
                    await WortPause();
                    continue;
                }
            }
        }
    }
}
