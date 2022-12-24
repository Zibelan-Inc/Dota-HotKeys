using Dota_HotKeys.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Shortcut;
using AutoHotkey.Interop;
using Dota_HotKeys.Class;
using System.Diagnostics;
using Microsoft.VisualBasic;
using static System.Resources.ResXFileRef;
using System.Timers;

namespace Dota_HotKeys.frm
{
    public partial class ComboManager : UserControl
    {
        [DllImport("user32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);

        string originalnamehero;
        bool prevnext;
        bool pressctrl = false;

        public ComboManager()
        {
            InitializeComponent();
        }
        private void ComboManager_Load(object sender, EventArgs e)
        {
            if (File.Exists(modCommon.Name_File))
            {
                modCommon.Deserializar();
                Combo1.Text = modCommon.confi.Keys42;
                Combo2.Text = modCommon.confi.Keys43;
                Combo3.Text = modCommon.confi.Keys44;
                Combo4.Text = modCommon.confi.Keys45;
                Combo5.Text = modCommon.confi.Keys46;


                if(modCommon.confi.AutoDelivery == "True")
                {
                    AutoDeliveryToggle.Checked = true;
                }
                else
                {
                    AutoDeliveryToggle.Checked = false;
                }
            }
            else
            {
                modCommon.confi.Keys42 = Combo1.Text;
                modCommon.confi.Keys43 = Combo2.Text;
                modCommon.confi.Keys44 = Combo3.Text;
                modCommon.confi.Keys45 = Combo4.Text;
                modCommon.confi.Keys46 = Combo5.Text;

                if(AutoDeliveryToggle.Checked == true)
                {
                    modCommon.confi.AutoDelivery = "True";
                }
                else
                {
                    modCommon.confi.AutoDelivery = "False";
                }
                modCommon.Serializar();
            }
            modCommon.vernamehero(modCommon.idhero);
            nameHero.Text = modCommon.namehero;
            originalnamehero = modCommon.namehero;
            ValorHero(modCommon.namehero);
            verordenhero();
        }
        private void ValorHero(string namehero)
        {
            switch (namehero)
            {
                case "Abaddom":
                    typeHero.Text = modCommon.Abaddom.TypeHero;
                    rangeHero.Text = modCommon.Abaddom.RangeHero;
                    break;

                case "Alchemist":
                    typeHero.Text = modCommon.Alchemist.TypeHero;
                    rangeHero.Text = modCommon.Alchemist.RangeHero;
                    break;

                case "Axe":
                    typeHero.Text = modCommon.Axe.TypeHero;
                    rangeHero.Text = modCommon.Axe.RangeHero;
                    break;

                case "Beastmaster":
                    typeHero.Text = modCommon.Beastmaster.TypeHero;
                    rangeHero.Text = modCommon.Beastmaster.RangeHero;
                    break;

                case "Brewmaster":
                    typeHero.Text = modCommon.Brewmaster.TypeHero;
                    rangeHero.Text = modCommon.Brewmaster.RangeHero;
                    break;

                case "Bristleback":
                    typeHero.Text = modCommon.Bristleback.TypeHero;
                    rangeHero.Text = modCommon.Bristleback.RangeHero;
                    break;

                case "Centaur Warrunner":
                    typeHero.Text = modCommon.Centaur_Warrunner.TypeHero;
                    rangeHero.Text = modCommon.Centaur_Warrunner.RangeHero;
                    break;

                case "Chaos Knight":
                    typeHero.Text = modCommon.Chaos_Knight.TypeHero;
                    rangeHero.Text = modCommon.Chaos_Knight.RangeHero;
                    break;

                case "Clockwerk":
                    typeHero.Text = modCommon.Clockwerk.TypeHero;
                    rangeHero.Text = modCommon.Clockwerk.RangeHero;
                    break;

                case "Dawmbreaker":
                    typeHero.Text = modCommon.Dawmbreaker.TypeHero;
                    rangeHero.Text = modCommon.Dawmbreaker.RangeHero;
                    break;

                case "Doom":
                    typeHero.Text = modCommon.Doom.TypeHero;
                    rangeHero.Text = modCommon.Doom.RangeHero;
                    break;

                case "Dragon Kinght":
                    typeHero.Text = modCommon.Dragon_Knight.TypeHero;
                    rangeHero.Text = modCommon.Dragon_Knight.RangeHero;
                    break;

                case "Earth Spirit":
                    typeHero.Text = modCommon.Earth_Spirit.TypeHero;
                    rangeHero.Text = modCommon.Earth_Spirit.RangeHero;
                    break;

                case "Earthshaker":
                    typeHero.Text = modCommon.Earthshaker.TypeHero;
                    rangeHero.Text = modCommon.Earthshaker.RangeHero;
                    break;

                case "Elden Titan":
                    typeHero.Text = modCommon.Elden_Titan.TypeHero;
                    rangeHero.Text = modCommon.Elden_Titan.RangeHero;
                    break;

                case "Huskar":
                    typeHero.Text = modCommon.Huskar.TypeHero;
                    rangeHero.Text = modCommon.Huskar.RangeHero;
                    break;

                case "Io":
                    typeHero.Text = modCommon.Io.TypeHero;
                    rangeHero.Text = modCommon.Io.RangeHero;
                    break;

                case "Kunkka":
                    typeHero.Text = modCommon.Kunkka.TypeHero;
                    rangeHero.Text = modCommon.Kunkka.RangeHero;
                    break;

                case "Legion Commander":
                    typeHero.Text = modCommon.Legion_Commander.TypeHero;
                    rangeHero.Text = modCommon.Legion_Commander.RangeHero;
                    break;

                case "Lifesteales":
                    typeHero.Text = modCommon.Lifesteales.TypeHero;
                    rangeHero.Text = modCommon.Lifesteales.RangeHero;
                    break;

                case "Lycan":
                    typeHero.Text = modCommon.Lycan.TypeHero;
                    rangeHero.Text = modCommon.Lycan.RangeHero;
                    break;

                case "Magnus":
                    typeHero.Text = modCommon.Magnus.TypeHero;
                    rangeHero.Text = modCommon.Magnus.RangeHero;
                    break;

                case "Marci":
                    typeHero.Text = modCommon.Marci.TypeHero;
                    rangeHero.Text = modCommon.Marci.RangeHero;
                    break;

                case "Mars":
                    typeHero.Text = modCommon.Mars.TypeHero;
                    rangeHero.Text = modCommon.Mars.RangeHero;
                    break;

                case "Night Stalker":
                    typeHero.Text = modCommon.Night_Stalker.TypeHero;
                    rangeHero.Text = modCommon.Night_Stalker.RangeHero;
                    break;

                case "Omniknight":
                    typeHero.Text = modCommon.Omniknight.TypeHero;
                    rangeHero.Text = modCommon.Omniknight.RangeHero;
                    break;

                case "Phoenix":
                    typeHero.Text = modCommon.Phoenix.TypeHero;
                    rangeHero.Text = modCommon.Phoenix.RangeHero;
                    break;

                case "Pudge":
                    typeHero.Text = modCommon.Pudge.TypeHero;
                    rangeHero.Text = modCommon.Pudge.RangeHero;
                    break;

                case "Sand Kinght":
                    typeHero.Text = modCommon.Sand_Knight.TypeHero;
                    rangeHero.Text = modCommon.Sand_Knight.RangeHero;
                    break;

                case "Slardar":
                    typeHero.Text = modCommon.Slardar.TypeHero;
                    rangeHero.Text = modCommon.Slardar.RangeHero;
                    break;

                case "Snapfire":
                    typeHero.Text = modCommon.Snapfire.TypeHero;
                    rangeHero.Text = modCommon.Snapfire.RangeHero;
                    break;

                case "Spirit Breaker":
                    typeHero.Text = modCommon.Spirit_Breaker.TypeHero;
                    rangeHero.Text = modCommon.Spirit_Breaker.RangeHero;
                    break;

                case "Sven":
                    typeHero.Text = modCommon.Sven.TypeHero;
                    rangeHero.Text = modCommon.Sven.RangeHero;
                    break;

                case "Tidehunter":
                    typeHero.Text = modCommon.Tidehunter.TypeHero;
                    rangeHero.Text = modCommon.Tidehunter.RangeHero;
                    break;

                case "Timbersaw":
                    typeHero.Text = modCommon.Timbersaw.TypeHero;
                    rangeHero.Text = modCommon.Timbersaw.RangeHero;
                    break;

                case "Tiny":
                    typeHero.Text = modCommon.Tiny.TypeHero;
                    rangeHero.Text = modCommon.Tiny.RangeHero;
                    break;

                case "Treant Protector":
                    typeHero.Text = modCommon.Treant_Protector.TypeHero;
                    rangeHero.Text = modCommon.Treant_Protector.RangeHero;
                    break;

                case "Tusk":
                    typeHero.Text = modCommon.Tusk.TypeHero;
                    rangeHero.Text = modCommon.Tusk.RangeHero;
                    break;

                case "Underlord":
                    typeHero.Text = modCommon.Underlord.TypeHero;
                    rangeHero.Text = modCommon.Underlord.RangeHero;
                    break;

                case "Undying":
                    typeHero.Text = modCommon.Undying.TypeHero;
                    rangeHero.Text = modCommon.Undying.RangeHero;
                    break;

                case "Wraith Kinght":
                    typeHero.Text = modCommon.Wraith_Knight.TypeHero;
                    rangeHero.Text = modCommon.Wraith_Knight.RangeHero;
                    break;

                case "Anti-Mage":
                    typeHero.Text = modCommon.Anti_Mage.TypeHero;
                    rangeHero.Text = modCommon.Anti_Mage.RangeHero;
                    break;

                case "Ark Warden":
                    typeHero.Text = modCommon.Ark_Warden.TypeHero;
                    rangeHero.Text = modCommon.Ark_Warden.RangeHero;
                    break;

                case "Bloodseaker":
                    typeHero.Text = modCommon.Bloodseaker.TypeHero;
                    rangeHero.Text = modCommon.Bloodseaker.RangeHero;
                    break;

                case "Bounty Hunter":
                    typeHero.Text = modCommon.Bounty_Hunter.TypeHero;
                    rangeHero.Text = modCommon.Bounty_Hunter.RangeHero;
                    break;

                case "Broodmother":
                    typeHero.Text = modCommon.Broodmother.TypeHero;
                    rangeHero.Text = modCommon.Broodmother.RangeHero;
                    break;

                case "Clinkz":
                    typeHero.Text = modCommon.Clinkz.TypeHero;
                    rangeHero.Text = modCommon.Clinkz.RangeHero;
                    break;

                case "Drow Ranger":
                    typeHero.Text = modCommon.Drow_Ranger.TypeHero;
                    rangeHero.Text = modCommon.Drow_Ranger.RangeHero;
                    break;

                case "Ember Spirit":
                    typeHero.Text = modCommon.Ember_Spirit.TypeHero;
                    rangeHero.Text = modCommon.Ember_Spirit.RangeHero;
                    break;

                case "Faceless Void":
                    typeHero.Text = modCommon.Faceless_Void.TypeHero;
                    rangeHero.Text = modCommon.Faceless_Void.RangeHero;
                    break;

                case "Gyrocopter":
                    typeHero.Text = modCommon.Gyrocopter.TypeHero;
                    rangeHero.Text = modCommon.Gyrocopter.RangeHero;
                    break;

                case "Hoodwink":
                    typeHero.Text = modCommon.Hoodwink.TypeHero;
                    rangeHero.Text = modCommon.Hoodwink.RangeHero;
                    break;

                case "Juggernaut":
                    typeHero.Text = modCommon.Juggernaut.TypeHero;
                    rangeHero.Text = modCommon.Juggernaut.RangeHero;
                    break;

                case "Lone Druid":
                    typeHero.Text = modCommon.Lone_Druid.TypeHero;
                    rangeHero.Text = modCommon.Lone_Druid.RangeHero;
                    break;

                case "Luna":
                    typeHero.Text = modCommon.Luna.TypeHero;
                    rangeHero.Text = modCommon.Luna.RangeHero;
                    break;

                case "Medusa":
                    typeHero.Text = modCommon.Medusa.TypeHero;
                    rangeHero.Text = modCommon.Medusa.RangeHero;
                    break;

                case "Meepo":
                    typeHero.Text = modCommon.Meepo.TypeHero;
                    rangeHero.Text = modCommon.Meepo.RangeHero;
                    break;

                case "Mirana":
                    typeHero.Text = modCommon.Mirana.TypeHero;
                    rangeHero.Text = modCommon.Mirana.RangeHero;
                    break;

                case "Monkey Kinght":
                    typeHero.Text = modCommon.Monkey_Knight.TypeHero;
                    rangeHero.Text = modCommon.Monkey_Knight.RangeHero;
                    break;

                case "Morphling":
                    typeHero.Text = modCommon.Morphling.TypeHero;
                    rangeHero.Text = modCommon.Morphling.RangeHero;
                    break;

                case "Naga Siren":
                    typeHero.Text = modCommon.Naga_Siren.TypeHero;
                    rangeHero.Text = modCommon.Naga_Siren.RangeHero;
                    break;

                case "Nyx Assassin":
                    typeHero.Text = modCommon.Nyx_Assassin.TypeHero;
                    rangeHero.Text = modCommon.Nyx_Assassin.RangeHero;
                    break;

                case "Pangolier":
                    typeHero.Text = modCommon.Pangolier.TypeHero;
                    rangeHero.Text = modCommon.Pangolier.RangeHero;
                    break;

                case "Phantom Assassin":
                    typeHero.Text = modCommon.Phantom_Assassin.TypeHero;
                    rangeHero.Text = modCommon.Phantom_Assassin.RangeHero;
                    break;

                case "Phantom Lancer":
                    typeHero.Text = modCommon.Phantom_Lancer.TypeHero;
                    rangeHero.Text = modCommon.Phantom_Lancer.RangeHero;
                    break;

                case "Razor":
                    typeHero.Text = modCommon.Razor.TypeHero;
                    rangeHero.Text = modCommon.Razor.RangeHero;
                    break;

                case "Riki":
                    typeHero.Text = modCommon.Riki.TypeHero;
                    rangeHero.Text = modCommon.Riki.RangeHero;
                    break;

                case "Shadow Fiend":
                    typeHero.Text = modCommon.Shadow_Fiend.TypeHero;
                    rangeHero.Text = modCommon.Shadow_Fiend.RangeHero;
                    break;

                case "Slark":
                    typeHero.Text = modCommon.Slark.TypeHero;
                    rangeHero.Text = modCommon.Slark.RangeHero;
                    break;

                case "Sniper":
                    typeHero.Text = modCommon.Sniper.TypeHero;
                    rangeHero.Text = modCommon.Sniper.RangeHero;
                    break;

                case "Spectre":
                    typeHero.Text = modCommon.Spectre.TypeHero;
                    rangeHero.Text = modCommon.Spectre.RangeHero;
                    break;

                case "Templar Assassin":
                    typeHero.Text = modCommon.Templar_Assassin.TypeHero;
                    rangeHero.Text = modCommon.Templar_Assassin.RangeHero;
                    break;

                case "Terrorblade":
                    typeHero.Text = modCommon.Terrorblade.TypeHero;
                    rangeHero.Text = modCommon.Terrorblade.RangeHero;
                    break;

                case "Troll Warlord":
                    typeHero.Text = modCommon.Troll_Warlord.TypeHero;
                    rangeHero.Text = modCommon.Troll_Warlord.RangeHero;
                    break;

                case "Ursa":
                    typeHero.Text = modCommon.Ursa.TypeHero;
                    rangeHero.Text = modCommon.Ursa.RangeHero;
                    break;

                case "Vengeful Spirit":
                    typeHero.Text = modCommon.Vengeful_Spirit.TypeHero;
                    rangeHero.Text = modCommon.Vengeful_Spirit.RangeHero;
                    break;

                case "Venomancer":
                    typeHero.Text = modCommon.Venomancer.TypeHero;
                    rangeHero.Text = modCommon.Venomancer.RangeHero;
                    break;

                case "Viper":
                    typeHero.Text = modCommon.Viper.TypeHero;
                    rangeHero.Text = modCommon.Viper.RangeHero;
                    break;

                case "Weaver":
                    typeHero.Text = modCommon.Weaver.TypeHero;
                    rangeHero.Text = modCommon.Weaver.RangeHero;
                    break;

                case "Ancient Apparition":
                    typeHero.Text = modCommon.Ancient_Apparition.TypeHero;
                    rangeHero.Text = modCommon.Ancient_Apparition.RangeHero;
                    break;

                case "Bane":
                    typeHero.Text = modCommon.Bane.TypeHero;
                    rangeHero.Text = modCommon.Bane.RangeHero;
                    break;

                case "Batrider":
                    typeHero.Text = modCommon.Batrider.TypeHero;
                    rangeHero.Text = modCommon.Batrider.RangeHero;
                    break;

                case "Chen":
                    typeHero.Text = modCommon.Chen.TypeHero;
                    rangeHero.Text = modCommon.Chen.RangeHero;
                    break;

                case "Crystal Maiden":
                    typeHero.Text = modCommon.Crystal_Maiden.TypeHero;
                    rangeHero.Text = modCommon.Crystal_Maiden.RangeHero;
                    break;

                case "Dark Seer":
                    typeHero.Text = modCommon.Dark_Seer.TypeHero;
                    rangeHero.Text = modCommon.Dark_Seer.RangeHero;
                    break;

                case "Dark Willow":
                    typeHero.Text = modCommon.Dark_Willow.TypeHero;
                    rangeHero.Text = modCommon.Dark_Willow.RangeHero;
                    break;

                case "Dazzle":
                    typeHero.Text = modCommon.Dazzle.TypeHero;
                    rangeHero.Text = modCommon.Dazzle.RangeHero;
                    break;

                case "Death Prophet":
                    typeHero.Text = modCommon.Death_Prophet.TypeHero;
                    rangeHero.Text = modCommon.Death_Prophet.RangeHero;
                    break;

                case "Disruptor":
                    typeHero.Text = modCommon.Disruptor.TypeHero;
                    rangeHero.Text = modCommon.Disruptor.RangeHero;
                    break;

                case "Enchantress":
                    typeHero.Text = modCommon.Enchantress.TypeHero;
                    rangeHero.Text = modCommon.Enchantress.RangeHero;
                    break;

                case "Enigma":
                    typeHero.Text = modCommon.Enigma.TypeHero;
                    rangeHero.Text = modCommon.Enigma.RangeHero;
                    break;

                case "Grimstroke":
                    typeHero.Text = modCommon.Grimstroke.TypeHero;
                    rangeHero.Text = modCommon.Grimstroke.RangeHero;
                    break;

                case "Invoker":
                    typeHero.Text = modCommon.Invoker.TypeHero;
                    rangeHero.Text = modCommon.Invoker.RangeHero;
                    break;

                case "Jakiro":
                    typeHero.Text = modCommon.Jakiro.TypeHero;
                    rangeHero.Text = modCommon.Jakiro.RangeHero;
                    break;

                case "Keeper of the Light":
                    typeHero.Text = modCommon.Keeper_of_the_Light.TypeHero;
                    rangeHero.Text = modCommon.Keeper_of_the_Light.RangeHero;
                    break;

                case "Leshrac":
                    typeHero.Text = modCommon.Leshrac.TypeHero;
                    rangeHero.Text = modCommon.Leshrac.RangeHero;
                    break;

                case "Lich":
                    typeHero.Text = modCommon.Lich.TypeHero;
                    rangeHero.Text = modCommon.Lich.RangeHero;
                    break;

                case "Lina":
                    typeHero.Text = modCommon.Lina.TypeHero;
                    rangeHero.Text = modCommon.Lina.RangeHero;
                    break;

                case "Lion":
                    typeHero.Text = modCommon.Lion.TypeHero;
                    rangeHero.Text = modCommon.Lion.RangeHero;
                    break;

                case "Nature's Prophet":
                    typeHero.Text = modCommon.Nature_s_Prophet.TypeHero;
                    rangeHero.Text = modCommon.Nature_s_Prophet.RangeHero;
                    break;

                case "Necrophos":
                    typeHero.Text = modCommon.Necrophos.TypeHero;
                    rangeHero.Text = modCommon.Necrophos.RangeHero;
                    break;

                case "Ogre Magi":
                    typeHero.Text = modCommon.Ogre_Magi.TypeHero;
                    rangeHero.Text = modCommon.Ogre_Magi.RangeHero;
                    break;

                case "Oracle":
                    typeHero.Text = modCommon.Oracle.TypeHero;
                    rangeHero.Text = modCommon.Oracle.RangeHero;
                    break;

                case "Outword Destroyer":
                    typeHero.Text = modCommon.Outword_Destroyer.TypeHero;
                    rangeHero.Text = modCommon.Outword_Destroyer.RangeHero;
                    break;

                case "Puck":
                    typeHero.Text = modCommon.Puck.TypeHero;
                    rangeHero.Text = modCommon.Puck.RangeHero;
                    break;

                case "Pugna":
                    typeHero.Text = modCommon.Pugna.TypeHero;
                    rangeHero.Text = modCommon.Pugna.RangeHero;
                    break;

                case "Queen of Pain":
                    typeHero.Text = modCommon.Queen_of_Pain.TypeHero;
                    rangeHero.Text = modCommon.Queen_of_Pain.RangeHero;
                    break;

                case "Rubick":
                    typeHero.Text = modCommon.Rubick.TypeHero;
                    rangeHero.Text = modCommon.Rubick.RangeHero;
                    break;

                case "Shadow Demon":
                    typeHero.Text = modCommon.Shadow_Demon.TypeHero;
                    rangeHero.Text = modCommon.Shadow_Demon.RangeHero;
                    break;

                case "Shadow Shaman":
                    typeHero.Text = modCommon.Shadow_Shaman.TypeHero;
                    rangeHero.Text = modCommon.Shadow_Shaman.RangeHero;
                    break;

                case "Silencer":
                    typeHero.Text = modCommon.Silencer.TypeHero;
                    rangeHero.Text = modCommon.Silencer.RangeHero;
                    break;

                case "Skywrath Magi":
                    typeHero.Text = modCommon.Skywrath_Magi.TypeHero;
                    rangeHero.Text = modCommon.Skywrath_Magi.RangeHero;
                    break;

                case "Storm Spirit":
                    typeHero.Text = modCommon.Storm_Spirit.TypeHero;
                    rangeHero.Text = modCommon.Storm_Spirit.RangeHero;
                    break;

                case "Techies":
                    typeHero.Text = modCommon.Techies.TypeHero;
                    rangeHero.Text = modCommon.Techies.RangeHero;
                    break;

                case "Tinker":
                    typeHero.Text = modCommon.Tinker.TypeHero;
                    rangeHero.Text = modCommon.Tinker.RangeHero;
                    break;

                case "Visage":
                    typeHero.Text = modCommon.Visage.TypeHero;
                    rangeHero.Text = modCommon.Visage.RangeHero;
                    break;

                case "Void Spirit":
                    typeHero.Text = modCommon.Void_Spirit.TypeHero;
                    rangeHero.Text = modCommon.Void_Spirit.RangeHero;
                    break;

                case "Warlock":
                    typeHero.Text = modCommon.Warlock.TypeHero;
                    rangeHero.Text = modCommon.Warlock.RangeHero;
                    break;

                case "Windranger":
                    typeHero.Text = modCommon.Windranger.TypeHero;
                    rangeHero.Text = modCommon.Windranger.RangeHero;
                    break;

                case "Winter Wyvern":
                    typeHero.Text = modCommon.Winter_Wyvern.TypeHero;
                    rangeHero.Text = modCommon.Winter_Wyvern.RangeHero;
                    break;

                case "Witch Doctor":
                    typeHero.Text = modCommon.Witch_Doctor.TypeHero;
                    rangeHero.Text = modCommon.Witch_Doctor.RangeHero;
                    break;

                case "Zeus":
                    typeHero.Text = modCommon.Zeus.TypeHero;
                    rangeHero.Text = modCommon.Zeus.RangeHero;
                    break;
            }
        }
        private void Prevnext()
        {
            if (prevnext == false)
            {
                int temp0 = Convert.ToInt32(modCommon.idhero.Split('n')[1]);
                temp0 = temp0 - 1;
                modCommon.vernamehero(Convert.ToString("button" + temp0));
                nameHero.Text = modCommon.namehero;
                originalnamehero = modCommon.namehero;
                ValorHero(modCommon.namehero);
                modCommon.idhero = "button" + temp0;

                if (temp0 != 122)
                {
                    modCommon.vernamehero("button" + Convert.ToInt32(temp0 + 1));
                    nameHeronext.Text = modCommon.namehero;
                    modCommon.namehero = originalnamehero;
                }
                if (originalnamehero == "Abaddom")
                {
                    previusHero.Visible = false;
                    nameHeroprev.Visible = false;
                }
                else if (originalnamehero == "Anti-Mage")
                {
                    previusHero.Visible = false;
                    nameHeroprev.Visible = false;
                }
                else if (originalnamehero == "Ancient Apparition")
                {
                    previusHero.Visible = false;
                    nameHeroprev.Visible = false;
                }
                else if (originalnamehero == "Zeus")
                {
                    nextHero.Visible = false;
                    nameHeronext.Visible = false;
                }
                else
                {
                    int temp = temp0;
                    if (temp != 1)
                    {
                        modCommon.vernamehero("button" + Convert.ToInt32(temp - 1));
                        nameHeroprev.Text = modCommon.namehero;
                        modCommon.namehero = originalnamehero;
                    }
                }
            }
            else
            {
                int temp0 = Convert.ToInt32(modCommon.idhero.Split('n')[1]);
                temp0 = temp0 + 1;
                modCommon.vernamehero(Convert.ToString("button" + temp0));
                nameHero.Text = modCommon.namehero;
                originalnamehero = modCommon.namehero;
                ValorHero(modCommon.namehero);
                modCommon.idhero = "button" + temp0;

                if (temp0 != 122)
                {
                    modCommon.vernamehero("button" + Convert.ToInt32(temp0 + 1));
                    nameHeronext.Text = modCommon.namehero;
                    modCommon.namehero = originalnamehero;
                }
                if (originalnamehero == "Abaddom")
                {
                    previusHero.Visible = false;
                    nameHeroprev.Visible = false;
                }
                else if (originalnamehero == "Anti-Mage")
                {
                    previusHero.Visible = false;
                    nameHeroprev.Visible = false;
                }
                else if (originalnamehero == "Ancient Apparition")
                {
                    previusHero.Visible = false;
                    nameHeroprev.Visible = false;
                }
                else if (originalnamehero == "Zeus")
                {
                    nextHero.Visible = false;
                    nameHeronext.Visible = false;
                }
                else
                {
                    int temp = temp0;
                    if (temp != 1)
                    {
                        modCommon.vernamehero("button" + Convert.ToInt32(temp - 1));
                        nameHeroprev.Text = modCommon.namehero;
                        modCommon.namehero = originalnamehero;
                    }
                }
            }
        }
        private void verordenhero()
        {
            int temp0 = Convert.ToInt32(modCommon.idhero.Split('n')[1]);
            if (temp0 != 122)
            {
                modCommon.vernamehero("button" + Convert.ToInt32(temp0 + 1));
                nameHeronext.Text = modCommon.namehero;
                modCommon.namehero = originalnamehero;
            }
            if (originalnamehero == "Abaddom")
            {
                previusHero.Visible = false;
                nameHeroprev.Visible = false;
            }
            else if (originalnamehero == "Anti-Mage")
            {
                previusHero.Visible = false;
                nameHeroprev.Visible = false;
            }
            else if (originalnamehero == "Ancient Apparition")
            {
                previusHero.Visible = false;
                nameHeroprev.Visible = false;
            }
            else if (originalnamehero == "Zeus")
            {
                nextHero.Visible = false;
                nameHeronext.Visible = false;
            }
            else
            {
                int temp = Convert.ToInt32(modCommon.idhero.Split('n')[1]);
                if(temp != 1)
                {
                    modCommon.vernamehero("button" + Convert.ToInt32(temp - 1));
                    nameHeroprev.Text = modCommon.namehero;
                    modCommon.namehero = originalnamehero;
                }
            }
        }
        private void previusHero_Click(object sender, EventArgs e)
        {
            prevnext = false;
            Prevnext();
        }
        private void previusHero_MouseLeave(object sender, EventArgs e)
        {
            previusHero.Image = Resources.Left1;
            nameHeroprev.ForeColor = Color.FromArgb(115, 122, 124);
        }
        private void previusHero_MouseMove(object sender, MouseEventArgs e)
        {
            previusHero.Image = Resources.Left2;
            nameHeroprev.ForeColor = Color.White;
        }
        private void nextHero_Click(object sender, EventArgs e)
        {
            prevnext = true;
            Prevnext();
        }
        private void nextHero_MouseLeave(object sender, EventArgs e)
        {
            nextHero.Image = Resources.Rigth1;
            nameHeronext.ForeColor = Color.FromArgb(115, 122, 124);
        }
        private void nextHero_MouseMove(object sender, MouseEventArgs e)
        {
            nextHero.Image = Resources.Rigth2;
            nameHeronext.ForeColor = Color.White;
        }
        private void Combo_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
            button.FillColor = Color.FromArgb(100, 88, 255);
        }
        private void Key_MouseLeave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
            button.FillColor = Color.FromArgb(44, 48, 49);
        }
        private void Key_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
            string temp = Convert.ToString(e.KeyCode);
            if (button.Text != temp)
            {
                if (pressctrl != true)
                {
                    if (temp == "ControlKey")
                    {
                        pressctrl = true;
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    if(temp == "NumPad0")
                    {
                        temp = "0";
                    }
                    if (temp == "D0")
                    {
                        temp = "0";
                    }
                    if (temp == "NumPad1")
                    {
                        temp = "1";
                    }
                    if (temp == "D1")
                    {
                        temp = "1";
                    }
                    if (temp == "NumPad2")
                    {
                        temp = "2";
                    }
                    if (temp == "D2")
                    {
                        temp = "2";
                    }
                    if (temp == "NumPad3")
                    {
                        temp = "3";
                    }
                    if (temp == "D3")
                    {
                        temp = "3";
                    }
                    if (temp == "NumPad4")
                    {
                        temp = "4";
                    }
                    if (temp == "D4")
                    {
                        temp = "4";
                    }
                    if (temp == "NumPad5")
                    {
                        temp = "5";
                    }
                    if (temp == "D5")
                    {
                        temp = "5";
                    }
                    if (temp == "NumPad6")
                    {
                        temp = "6";
                    }
                    if (temp == "D6")
                    {
                        temp = "6";
                    }
                    if (temp == "NumPad7")
                    {
                        temp = "7";
                    }
                    if (temp == "D7")
                    {
                        temp = "7";
                    }
                    if (temp == "NumPad8")
                    {
                        temp = "8";
                    }
                    if (temp == "D8")
                    {
                        temp = "8";
                    }
                    if (temp == "NumPad9")
                    {
                        temp = "9";
                    }
                    if (temp == "D9")
                    {
                        temp = "9";
                    }
                    string temp2 = "Ctrl + " + temp;
                    if (temp == "0" | temp == "1" | temp == "2" | temp == "3" | temp == "4" | temp == "5" | temp == "6" | temp == "7" | temp == "8" | temp == "9")
                    {
                        VerKeys(temp2);
                        if (modCommon.existkeys != true)
                        {
                            button.Text = temp2;
                            button.FillColor = Color.FromArgb(44, 48, 49);

                            if(button.Name == "Combo1")
                            {
                                modCommon.confi.Keys42 = Combo1.Text;
                            }
                            if (button.Name == "Combo2")
                            {
                                modCommon.confi.Keys43 = Combo2.Text;
                            }
                            if (button.Name == "Combo3")
                            {
                                modCommon.confi.Keys44 = Combo3.Text;
                            }
                            if (button.Name == "Combo4")
                            {
                                modCommon.confi.Keys45 = Combo4.Text;
                            }
                            if (button.Name == "Combo5")
                            {
                                modCommon.confi.Keys46 = Combo5.Text;
                            }
                            modCommon.Serializar();
                        }
                        else
                        {
                            button.FillColor = Color.FromArgb(255, 48, 49);
                            modCommon.existkeys = false;
                        }
                    }
                    else
                    {
                        return;
                    }
                    pressctrl = false;
                }
            }
        }
        private void VerKeys(string keys)
        {
            if (keys == modCommon.confi.Keys42)
            {
                modCommon.existkeys = true;
            }
            if (keys == modCommon.confi.Keys43)
            {
                modCommon.existkeys = true;
            }
            if (keys == modCommon.confi.Keys44)
            {
                modCommon.existkeys = true;
            }
            if (keys == modCommon.confi.Keys45)
            {
                modCommon.existkeys = true;
            }
            if (keys == modCommon.confi.Keys46)
            {
                modCommon.existkeys = true;
            }
        }
        private void Item_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2PictureBox button = (Guna.UI2.WinForms.Guna2PictureBox)sender;
            if (button.Name == "Item1")
            {
                Item2.Image = null;
                Item3.Image = null;
                Item4.Image = null;
                Item5.Image = null;
                Item6.Image = null;
                button.Image = Resources.powertread;
            }
            if (button.Name == "Item2")
            {
                Item1.Image = null;
                Item3.Image = null;
                Item4.Image = null;
                Item5.Image = null;
                Item6.Image = null;
                button.Image = Resources.powertread;
            }
            if (button.Name == "Item3")
            {
                Item1.Image = null;
                Item2.Image = null;
                Item4.Image = null;
                Item5.Image = null;
                Item6.Image = null;
                button.Image = Resources.powertread;
            }
            if (button.Name == "Item4")
            {
                Item1.Image = null;
                Item2.Image = null;
                Item3.Image = null;
                Item5.Image = null;
                Item6.Image = null;
                button.Image = Resources.powertread;
            }
            if (button.Name == "Item5")
            {
                Item1.Image = null;
                Item2.Image = null;
                Item3.Image = null;
                Item4.Image = null;
                Item6.Image = null;
                button.Image = Resources.powertread;
            }
            if (button.Name == "Item6")
            {
                Item1.Image = null;
                Item2.Image = null;
                Item3.Image = null;
                Item4.Image = null;
                Item5.Image = null;
                button.Image = Resources.powertread;
            }
            modCommon.Serializar();
        }
        private void Item_MouseMove(object sender, MouseEventArgs e)
        {
            Guna.UI2.WinForms.Guna2PictureBox button = (Guna.UI2.WinForms.Guna2PictureBox)sender;
            button.FillColor = Color.FromArgb(100, 88, 255);
        }
        private void Item_MouseLeave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2PictureBox button = (Guna.UI2.WinForms.Guna2PictureBox)sender;
            button.FillColor = Color.FromArgb(44, 48, 49);
        }

        private void AutoDeliveryToggle_CheckedChanged(object sender, EventArgs e)
        {
            if(AutoDeliveryToggle.Checked == true)
            {
                modCommon.confi.AutoDelivery = "True";
            }
            else
            {
                modCommon.confi.AutoDelivery = "False";
            }
            modCommon.Serializar();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if(Start.Text == "Start")
            {
                modCommon._hotkeyBinder.Bind(Modifiers.Alt, Keys.H).To(RoshanHour);

                if (modCommon.confi.AutoDelivery == "True")
                {
                    Keys key = (Keys)Enum.Parse(typeof(Keys), modCommon.confi.Keys19, true);
                    modCommon._hotkeyBinder.Bind(Modifiers.Control, key).To(Shop);
                }

                Start.Text = "Stop";
            }
            else
            {
                modCommon._hotkeyBinder.Unbind(Modifiers.Alt, Keys.H);
                Keys key = (Keys)Enum.Parse(typeof(Keys), modCommon.confi.Keys19, true);
                modCommon._hotkeyBinder.Unbind(Modifiers.Alt, key);
                Start.Text = "Start";
            }
        }
        private void RoshanHour()
        {
            if (modCommon.roshan == false)
            {
                modCommon.Alert("Roshan", frmAlert.alertTypeEnum.Roshan);
                modCommon.roshan = true;
            }
        }
        private void Shop()
        {
            var ahk = new AutoHotkeyEngine();
            string sayshopFunction = "Shop() \r\n { \r\n Send {" + modCommon.confi.Keys19 + " Down} \r\n Sleep, 100 \r\n Send {" + modCommon.confi.Keys19 + " Up} \r\n Send {" + modCommon.confi.Keys18 + " Down} \r\n Sleep, 100 \r\n Send {" + modCommon.confi.Keys18 + " Up} \r\n return \r\n }";
            ahk.ExecRaw(sayshopFunction);
            ahk.ExecRaw(@"Shop() ");
        }
    }
}
