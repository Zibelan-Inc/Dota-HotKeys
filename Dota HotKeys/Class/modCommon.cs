using Microsoft.Win32;
using Dota_HotKeys;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using Dota_HotKeys.Properties;
//using XNova_Utils;
using System.Text;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;
using Shortcut;

public class modCommon
{
    public static readonly HotkeyBinder _hotkeyBinder = new HotkeyBinder();
    //public static AutoHotkeyEngine ahk;

    private static Process currentProcess;
    public static bool Ready;
    public static string Name_File = "Settings.dat";
    public static Dota_HotKeys.Class.Confi confi = new Dota_HotKeys.Class.Confi();
    public static FileStream file;
    public static BinaryFormatter formatter;
    public static bool existkeys;
    public static bool uc;
    public static bool roshan;
    public static string namehero;
    public static string idhero;

    public static Dota_HotKeys.Hero.Abaddom Abaddom = new Dota_HotKeys.Hero.Abaddom();
    public static Dota_HotKeys.Hero.Alchemist Alchemist = new Dota_HotKeys.Hero.Alchemist();
    public static Dota_HotKeys.Hero.Ancient_Apparition Ancient_Apparition = new Dota_HotKeys.Hero.Ancient_Apparition();
    public static Dota_HotKeys.Hero.Anti_Mage Anti_Mage = new Dota_HotKeys.Hero.Anti_Mage();
    public static Dota_HotKeys.Hero.Ark_Warden Ark_Warden = new Dota_HotKeys.Hero.Ark_Warden();
    public static Dota_HotKeys.Hero.Axe Axe = new Dota_HotKeys.Hero.Axe();
    public static Dota_HotKeys.Hero.Bane Bane = new Dota_HotKeys.Hero.Bane();
    public static Dota_HotKeys.Hero.Batrider Batrider = new Dota_HotKeys.Hero.Batrider();
    public static Dota_HotKeys.Hero.Beastmaster Beastmaster = new Dota_HotKeys.Hero.Beastmaster();
    public static Dota_HotKeys.Hero.Bloodseaker Bloodseaker = new Dota_HotKeys.Hero.Bloodseaker();
    public static Dota_HotKeys.Hero.Bounty_Hunter Bounty_Hunter = new Dota_HotKeys.Hero.Bounty_Hunter();
    public static Dota_HotKeys.Hero.Brewmaster Brewmaster = new Dota_HotKeys.Hero.Brewmaster();
    public static Dota_HotKeys.Hero.Bristleback Bristleback = new Dota_HotKeys.Hero.Bristleback();
    public static Dota_HotKeys.Hero.Broodmother Broodmother = new Dota_HotKeys.Hero.Broodmother();
    public static Dota_HotKeys.Hero.Centaur_Warrunner Centaur_Warrunner = new Dota_HotKeys.Hero.Centaur_Warrunner();
    public static Dota_HotKeys.Hero.Chaos_Knight Chaos_Knight = new Dota_HotKeys.Hero.Chaos_Knight();
    public static Dota_HotKeys.Hero.Chen Chen = new Dota_HotKeys.Hero.Chen();
    public static Dota_HotKeys.Hero.Clinkz Clinkz = new Dota_HotKeys.Hero.Clinkz();
    public static Dota_HotKeys.Hero.Clockwerk Clockwerk = new Dota_HotKeys.Hero.Clockwerk();
    public static Dota_HotKeys.Hero.Crystal_Maiden Crystal_Maiden = new Dota_HotKeys.Hero.Crystal_Maiden();
    public static Dota_HotKeys.Hero.Dark_Seer Dark_Seer = new Dota_HotKeys.Hero.Dark_Seer();
    public static Dota_HotKeys.Hero.Dark_Willow Dark_Willow = new Dota_HotKeys.Hero.Dark_Willow();
    public static Dota_HotKeys.Hero.Dawmbreaker Dawmbreaker = new Dota_HotKeys.Hero.Dawmbreaker();
    public static Dota_HotKeys.Hero.Dazzle Dazzle = new Dota_HotKeys.Hero.Dazzle();
    public static Dota_HotKeys.Hero.Death_Prophet Death_Prophet = new Dota_HotKeys.Hero.Death_Prophet();
    public static Dota_HotKeys.Hero.Disruptor Disruptor = new Dota_HotKeys.Hero.Disruptor();
    public static Dota_HotKeys.Hero.Doom Doom = new Dota_HotKeys.Hero.Doom();
    public static Dota_HotKeys.Hero.Dragon_Knight Dragon_Knight = new Dota_HotKeys.Hero.Dragon_Knight();
    public static Dota_HotKeys.Hero.Drow_Ranger Drow_Ranger = new Dota_HotKeys.Hero.Drow_Ranger();
    public static Dota_HotKeys.Hero.Earth_Spirit Earth_Spirit = new Dota_HotKeys.Hero.Earth_Spirit();
    public static Dota_HotKeys.Hero.Earthshaker Earthshaker = new Dota_HotKeys.Hero.Earthshaker();
    public static Dota_HotKeys.Hero.Elden_Titan Elden_Titan = new Dota_HotKeys.Hero.Elden_Titan();
    public static Dota_HotKeys.Hero.Ember_Spirit Ember_Spirit = new Dota_HotKeys.Hero.Ember_Spirit();
    public static Dota_HotKeys.Hero.Enchantress Enchantress = new Dota_HotKeys.Hero.Enchantress();
    public static Dota_HotKeys.Hero.Enigma Enigma = new Dota_HotKeys.Hero.Enigma();
    public static Dota_HotKeys.Hero.Faceless_Void Faceless_Void = new Dota_HotKeys.Hero.Faceless_Void();
    public static Dota_HotKeys.Hero.Grimstroke Grimstroke = new Dota_HotKeys.Hero.Grimstroke();
    public static Dota_HotKeys.Hero.Gyrocopter Gyrocopter = new Dota_HotKeys.Hero.Gyrocopter();
    public static Dota_HotKeys.Hero.Hoodwink Hoodwink = new Dota_HotKeys.Hero.Hoodwink();
    public static Dota_HotKeys.Hero.Huskar Huskar = new Dota_HotKeys.Hero.Huskar();
    public static Dota_HotKeys.Hero.Invoker Invoker = new Dota_HotKeys.Hero.Invoker();
    public static Dota_HotKeys.Hero.Io Io = new Dota_HotKeys.Hero.Io();
    public static Dota_HotKeys.Hero.Jakiro Jakiro = new Dota_HotKeys.Hero.Jakiro();
    public static Dota_HotKeys.Hero.Juggernaut Juggernaut = new Dota_HotKeys.Hero.Juggernaut();
    public static Dota_HotKeys.Hero.Keeper_of_the_Light Keeper_of_the_Light = new Dota_HotKeys.Hero.Keeper_of_the_Light();
    public static Dota_HotKeys.Hero.Kunkka Kunkka = new Dota_HotKeys.Hero.Kunkka();
    public static Dota_HotKeys.Hero.Legion_Commander Legion_Commander = new Dota_HotKeys.Hero.Legion_Commander();
    public static Dota_HotKeys.Hero.Leshrac Leshrac = new Dota_HotKeys.Hero.Leshrac();
    public static Dota_HotKeys.Hero.Lich Lich = new Dota_HotKeys.Hero.Lich();
    public static Dota_HotKeys.Hero.Lifesteales Lifesteales = new Dota_HotKeys.Hero.Lifesteales();
    public static Dota_HotKeys.Hero.Lina Lina = new Dota_HotKeys.Hero.Lina();
    public static Dota_HotKeys.Hero.Lion Lion = new Dota_HotKeys.Hero.Lion();
    public static Dota_HotKeys.Hero.Lone_Druid Lone_Druid = new Dota_HotKeys.Hero.Lone_Druid();
    public static Dota_HotKeys.Hero.Luna Luna = new Dota_HotKeys.Hero.Luna();
    public static Dota_HotKeys.Hero.Lycan Lycan = new Dota_HotKeys.Hero.Lycan();
    public static Dota_HotKeys.Hero.Magnus Magnus = new Dota_HotKeys.Hero.Magnus();
    public static Dota_HotKeys.Hero.Marci Marci = new Dota_HotKeys.Hero.Marci();
    public static Dota_HotKeys.Hero.Mars Mars = new Dota_HotKeys.Hero.Mars();
    public static Dota_HotKeys.Hero.Medusa Medusa = new Dota_HotKeys.Hero.Medusa();
    public static Dota_HotKeys.Hero.Meepo Meepo = new Dota_HotKeys.Hero.Meepo();
    public static Dota_HotKeys.Hero.Mirana Mirana = new Dota_HotKeys.Hero.Mirana();
    public static Dota_HotKeys.Hero.Monkey_Knight Monkey_Knight = new Dota_HotKeys.Hero.Monkey_Knight();
    public static Dota_HotKeys.Hero.Morphling Morphling = new Dota_HotKeys.Hero.Morphling();
    public static Dota_HotKeys.Hero.Naga_Siren Naga_Siren = new Dota_HotKeys.Hero.Naga_Siren();
    public static Dota_HotKeys.Hero.Nature_s_Prophet Nature_s_Prophet = new Dota_HotKeys.Hero.Nature_s_Prophet();
    public static Dota_HotKeys.Hero.Necrophos Necrophos = new Dota_HotKeys.Hero.Necrophos();
    public static Dota_HotKeys.Hero.Night_Stalker Night_Stalker = new Dota_HotKeys.Hero.Night_Stalker();
    public static Dota_HotKeys.Hero.Nyx_Assassin Nyx_Assassin = new Dota_HotKeys.Hero.Nyx_Assassin();
    public static Dota_HotKeys.Hero.Ogre_Magi Ogre_Magi = new Dota_HotKeys.Hero.Ogre_Magi();
    public static Dota_HotKeys.Hero.Omniknight Omniknight = new Dota_HotKeys.Hero.Omniknight();
    public static Dota_HotKeys.Hero.Oracle Oracle = new Dota_HotKeys.Hero.Oracle();
    public static Dota_HotKeys.Hero.Outword_Destroyer Outword_Destroyer = new Dota_HotKeys.Hero.Outword_Destroyer();
    public static Dota_HotKeys.Hero.Pangolier Pangolier = new Dota_HotKeys.Hero.Pangolier();
    public static Dota_HotKeys.Hero.Phantom_Assassin Phantom_Assassin = new Dota_HotKeys.Hero.Phantom_Assassin();
    public static Dota_HotKeys.Hero.Phantom_Lancer Phantom_Lancer = new Dota_HotKeys.Hero.Phantom_Lancer();
    public static Dota_HotKeys.Hero.Phoenix Phoenix = new Dota_HotKeys.Hero.Phoenix();
    public static Dota_HotKeys.Hero.Puck Puck = new Dota_HotKeys.Hero.Puck();
    public static Dota_HotKeys.Hero.Pudge Pudge = new Dota_HotKeys.Hero.Pudge();
    public static Dota_HotKeys.Hero.Pugna Pugna = new Dota_HotKeys.Hero.Pugna();
    public static Dota_HotKeys.Hero.Queen_of_Pain Queen_of_Pain = new Dota_HotKeys.Hero.Queen_of_Pain();
    public static Dota_HotKeys.Hero.Razor Razor = new Dota_HotKeys.Hero.Razor();
    public static Dota_HotKeys.Hero.Riki Riki = new Dota_HotKeys.Hero.Riki();
    public static Dota_HotKeys.Hero.Rubick Rubick = new Dota_HotKeys.Hero.Rubick();
    public static Dota_HotKeys.Hero.Sand_Knight Sand_Knight = new Dota_HotKeys.Hero.Sand_Knight();
    public static Dota_HotKeys.Hero.Shadow_Demon Shadow_Demon = new Dota_HotKeys.Hero.Shadow_Demon();
    public static Dota_HotKeys.Hero.Shadow_Fiend Shadow_Fiend = new Dota_HotKeys.Hero.Shadow_Fiend();
    public static Dota_HotKeys.Hero.Shadow_Shaman Shadow_Shaman = new Dota_HotKeys.Hero.Shadow_Shaman();
    public static Dota_HotKeys.Hero.Silencer Silencer = new Dota_HotKeys.Hero.Silencer();
    public static Dota_HotKeys.Hero.Skywrath_Magi Skywrath_Magi = new Dota_HotKeys.Hero.Skywrath_Magi();
    public static Dota_HotKeys.Hero.Slardar Slardar = new Dota_HotKeys.Hero.Slardar();
    public static Dota_HotKeys.Hero.Slark Slark = new Dota_HotKeys.Hero.Slark();
    public static Dota_HotKeys.Hero.Snapfire Snapfire = new Dota_HotKeys.Hero.Snapfire();
    public static Dota_HotKeys.Hero.Sniper Sniper = new Dota_HotKeys.Hero.Sniper();
    public static Dota_HotKeys.Hero.Spectre Spectre = new Dota_HotKeys.Hero.Spectre();
    public static Dota_HotKeys.Hero.Spirit_Breaker Spirit_Breaker = new Dota_HotKeys.Hero.Spirit_Breaker();
    public static Dota_HotKeys.Hero.Storm_Spirit Storm_Spirit = new Dota_HotKeys.Hero.Storm_Spirit();
    public static Dota_HotKeys.Hero.Sven Sven = new Dota_HotKeys.Hero.Sven();
    public static Dota_HotKeys.Hero.Techies Techies = new Dota_HotKeys.Hero.Techies();
    public static Dota_HotKeys.Hero.Templar_Assassin Templar_Assassin = new Dota_HotKeys.Hero.Templar_Assassin();
    public static Dota_HotKeys.Hero.Terrorblade Terrorblade = new Dota_HotKeys.Hero.Terrorblade();
    public static Dota_HotKeys.Hero.Tidehunter Tidehunter = new Dota_HotKeys.Hero.Tidehunter();
    public static Dota_HotKeys.Hero.Timbersaw Timbersaw = new Dota_HotKeys.Hero.Timbersaw();
    public static Dota_HotKeys.Hero.Tinker Tinker = new Dota_HotKeys.Hero.Tinker();
    public static Dota_HotKeys.Hero.Tiny Tiny = new Dota_HotKeys.Hero.Tiny();
    public static Dota_HotKeys.Hero.Treant_Protector Treant_Protector = new Dota_HotKeys.Hero.Treant_Protector();
    public static Dota_HotKeys.Hero.Troll_Warlord Troll_Warlord = new Dota_HotKeys.Hero.Troll_Warlord();
    public static Dota_HotKeys.Hero.Tusk Tusk = new Dota_HotKeys.Hero.Tusk();
    public static Dota_HotKeys.Hero.Underlord Underlord = new Dota_HotKeys.Hero.Underlord();
    public static Dota_HotKeys.Hero.Undying Undying = new Dota_HotKeys.Hero.Undying();
    public static Dota_HotKeys.Hero.Ursa Ursa = new Dota_HotKeys.Hero.Ursa();
    public static Dota_HotKeys.Hero.Vengeful_Spirit Vengeful_Spirit = new Dota_HotKeys.Hero.Vengeful_Spirit();
    public static Dota_HotKeys.Hero.Venomancer Venomancer = new Dota_HotKeys.Hero.Venomancer();
    public static Dota_HotKeys.Hero.Viper Viper = new Dota_HotKeys.Hero.Viper();
    public static Dota_HotKeys.Hero.Visage Visage = new Dota_HotKeys.Hero.Visage();
    public static Dota_HotKeys.Hero.Void_Spirit Void_Spirit = new Dota_HotKeys.Hero.Void_Spirit();
    public static Dota_HotKeys.Hero.Warlock Warlock = new Dota_HotKeys.Hero.Warlock();
    public static Dota_HotKeys.Hero.Weaver Weaver = new Dota_HotKeys.Hero.Weaver();
    public static Dota_HotKeys.Hero.Windranger Windranger = new Dota_HotKeys.Hero.Windranger();
    public static Dota_HotKeys.Hero.Winter_Wyvern Winter_Wyvern = new Dota_HotKeys.Hero.Winter_Wyvern();
    public static Dota_HotKeys.Hero.Witch_Doctor Witch_Doctor = new Dota_HotKeys.Hero.Witch_Doctor();
    public static Dota_HotKeys.Hero.Wraith_Knight Wraith_Knight = new Dota_HotKeys.Hero.Wraith_Knight();
    public static Dota_HotKeys.Hero.Zeus Zeus = new Dota_HotKeys.Hero.Zeus();

    public static string CurrentDirectory
    {
        get
        {
            Process currentProcess = Process.GetCurrentProcess();
            return new FileInfo(currentProcess.MainModule.FileName).Directory.FullName;
        }
    }
    private static string GetDataDirectory()
    {
        try
        {
            currentProcess = Process.GetCurrentProcess();
            return new FileInfo(currentProcess.MainModule.FileName).Directory?.FullName + @"\Data";
        }
        finally { currentProcess = null; }
    }
    public static string Win32Path()
    {
        string correctGameFolder = "";
        RegistryKey exeKey = Registry.ClassesRoot.OpenSubKey("dota2\\Shell\\Open\\Command", true);
        if (exeKey != null)
        {
            string exeFile = exeKey.GetValue(null).ToString().Split('"')[1];
            correctGameFolder = Directory.GetParent(exeFile).ToString();

        }
        return correctGameFolder;
    }
    public static void Serializar()
    {
        if (File.Exists(Name_File))
        {
            file = new FileStream(Name_File, FileMode.Create);
            formatter = new BinaryFormatter();

            formatter.Serialize(file, confi);

            file.Close();
        }
        else
        {
            file = new FileStream(Name_File, FileMode.Create);
            formatter = new BinaryFormatter();

            formatter.Serialize(file, confi);

            file.Close();
        }
    }
    public static void Deserializar()
    {
        if (File.Exists(Name_File))
        {
            file = new FileStream(Name_File, FileMode.Open);
            formatter = new BinaryFormatter();

            confi = (Dota_HotKeys.Class.Confi)formatter.Deserialize(file);
            file.Close();
        }
    }
    public static void addUserControlHeroe(UserControl uc)
    {
        frmMain.frmmain.PanelContainer.Controls.Clear();
        uc.Dock = DockStyle.Fill;
        uc.BringToFront();
        frmMain.frmmain.PanelContainer.Controls.Add(uc);
    }
    public static void vernamehero(string id)
    {
        switch (id)
        {
            case "button1":
            namehero = "Abaddom";
            Abaddom.TypeHero = "Strength";
            Abaddom.RangeHero = "Melee";
            break;

            case "button2":
            namehero = "Alchemist";
            Alchemist.TypeHero = "Strength";
            Alchemist.RangeHero = "Melee";
            break;

            case "button3":
            namehero = "Axe";
            Axe.TypeHero = "Strength";
            Axe.RangeHero = "Melee";
            break;

            case "button4":
            namehero = "Beastmaster";
            Beastmaster.TypeHero = "Strength";
            Beastmaster.RangeHero = "Melee";
            break;

            case "button5":
            namehero = "Brewmaster";
            Brewmaster.TypeHero = "Strength";
            Brewmaster.RangeHero = "Melee";
            break;

            case "button6":
            namehero = "Bristleback";
            Bristleback.TypeHero = "Strength";
            Bristleback.RangeHero = "Melee";
            break;

            case "button7":
            namehero = "Centaur Warrunner";
            Centaur_Warrunner.TypeHero = "Strength";
            Centaur_Warrunner.RangeHero = "Melee";
            break;

            case "button8":
            namehero = "Chaos Knight";
            Chaos_Knight.TypeHero = "Strength";
            Chaos_Knight.RangeHero = "Melee";
            break;

            case "button9":
            namehero = "Clockwerk";
            Clockwerk.TypeHero = "Strength";
            Clockwerk.RangeHero = "Melee";
            break;

            case "button10":
            namehero = "Dawmbreaker";
            Dawmbreaker.TypeHero = "Strength";
            Dawmbreaker.RangeHero = "Melee";
            break;

            case "button11":
            namehero = "Doom";
            Doom.TypeHero = "Strength";
            Doom.RangeHero = "Melee";
            break;

            case "button12":
            namehero = "Dragon Kinght";
            Dragon_Knight.TypeHero = "Strength";
            Dragon_Knight.RangeHero = "Melee";
            break;

            case "button13":
            namehero = "Earth Spirit";
            Earth_Spirit.TypeHero = "Strength";
            Earth_Spirit.RangeHero = "Melee";
            break;

            case "button14":
            namehero = "Earthshaker";
            Earthshaker.TypeHero = "Strength";
            Earthshaker.RangeHero = "Melee";
            break;

            case "button15":
            namehero = "Elden Titan";
            Elden_Titan.TypeHero = "Strength";
            Elden_Titan.RangeHero = "Melee";
            break;

            case "button16":
            namehero = "Huskar";
            Huskar.TypeHero = "Strength";
            Huskar.RangeHero = "Ranged";
            break;

            case "button17":
            namehero = "Io";
            Io.TypeHero = "Strength";
            Io.RangeHero = "Ranged";
            break;

            case "button18":
            namehero = "Kunkka";
            Kunkka.TypeHero = "Strength";
            Kunkka.RangeHero = "Melee";
            break;

            case "button19":
            namehero = "Legion Commander";
            Legion_Commander.TypeHero = "Strength";
            Legion_Commander.RangeHero = "Melee";
            break;

            case "button20":
            namehero = "Lifesteales";
            Lifesteales.TypeHero = "Strength";
            Lifesteales.RangeHero = "Melee";
            break;

            case "button21":
            namehero = "Lycan";
            Lycan.TypeHero = "Strength";
            Lycan.RangeHero = "Melee";
            break;

            case "button22":
            namehero = "Magnus";
            Magnus.TypeHero = "Strength";
            Magnus.RangeHero = "Melee";
            break;

            case "button23":
            namehero = "Marci";
            Marci.TypeHero = "Strength";
            Marci.RangeHero = "Melee";
            break;

            case "button24":
            namehero = "Mars";
            Mars.TypeHero = "Strength";
            Mars.RangeHero = "Melee";
            break;

            case "button25":
            namehero = "Night Stalker";
            Night_Stalker.TypeHero = "Strength";
            Night_Stalker.RangeHero = "Melee";
            break;

            case "button26":
            namehero = "Omniknight";
            Omniknight.TypeHero = "Strength";
            Omniknight.RangeHero = "Melee";
            break;

            case "button27":
            namehero = "Phoenix";
            Phoenix.TypeHero = "Strength";
            Phoenix.RangeHero = "Ranged";
            break;

            case "button28":
            namehero = "Pudge";
            Pudge.TypeHero = "Strength";
            Pudge.RangeHero = "Melee";
            break;

            case "button29":
            namehero = "Sand Kinght";
            Sand_Knight.TypeHero = "Strength";
            Sand_Knight.RangeHero = "Melee";
            break;

            case "button30":
            namehero = "Slardar";
            Slardar.TypeHero = "Strength";
            Slardar.RangeHero = "Melee";
            break;

            case "button31":
            namehero = "Snapfire";
            Snapfire.TypeHero = "Strength";
            Snapfire.RangeHero = "Ranged";
            break;

            case "button32":
            namehero = "Spirit Breaker";
            Spirit_Breaker.TypeHero = "Strength";
            Spirit_Breaker.RangeHero = "Melee";
            break;

            case "button33":
            namehero = "Sven";
            Sven.TypeHero = "Strength";
            Sven.RangeHero = "Melee";
            break;

            case "button34":
            namehero = "Tidehunter";
            Tidehunter.TypeHero = "Strength";
            Tidehunter.RangeHero = "Melee";
            break;

            case "button35":
            namehero = "Timbersaw";
            Timbersaw.TypeHero = "Strength";
            Timbersaw.RangeHero = "Melee";
            break;

            case "button36":
            namehero = "Tiny";
            Tiny.TypeHero = "Strength";
            Tiny.RangeHero = "Melee";
            break;

            case "button37":
            namehero = "Treant Protector";
            Treant_Protector.TypeHero = "Strength";
            Treant_Protector.RangeHero = "Melee";
            break;

            case "button38":
            namehero = "Tusk";
            Tusk.TypeHero = "Strength";
            Tusk.RangeHero = "Melee";
            break;

            case "button39":
            namehero = "Underlord";
            Underlord.TypeHero = "Strength";
            Underlord.RangeHero = "Melee";
            break;

            case "button40":
            namehero = "Undying";
            Undying.TypeHero = "Strength";
            Undying.RangeHero = "Melee";
            break;

            case "button41":
            namehero = "Wraith Kinght";
            Wraith_Knight.TypeHero = "Strength";
            Wraith_Knight.RangeHero = "Melee";
            break;

            case "button42":
            namehero = "Anti-Mage";
            Anti_Mage.TypeHero = "Agility";
            Anti_Mage.RangeHero = "Melee";
            break;

            case "button43":
            namehero = "Ark Warden";
            Ark_Warden.TypeHero = "Agility";
            Ark_Warden.RangeHero = "Ranged";
            break;

            case "button44":
            namehero = "Bloodseaker";
            Bloodseaker.TypeHero = "Agility";
            Bloodseaker.RangeHero = "Melee";
            break;

            case "button45":
            namehero = "Bounty Hunter";
            Bounty_Hunter.TypeHero = "Agility";
            Bounty_Hunter.RangeHero = "Melee";
            break;

            case "button46":
            namehero = "Broodmother";
            Broodmother.TypeHero = "Agility";
            Broodmother.RangeHero = "Melee";
            break;

            case "button47":
            namehero = "Clinkz";
            Clinkz.TypeHero = "Agility";
            Clinkz.RangeHero = "Ranged";
            break;

            case "button48":
            namehero = "Drow Ranger";
            Drow_Ranger.TypeHero = "Agility";
            Drow_Ranger.RangeHero = "Ranged";
            break;

            case "button49":
            namehero = "Ember Spirit";
            Ember_Spirit.TypeHero = "Agility";
            Ember_Spirit.RangeHero = "Melee";
            break;

            case "button50":
            namehero = "Faceless Void";
            Faceless_Void.TypeHero = "Agility";
            Faceless_Void.RangeHero = "Melee";
            break;

            case "button51":
            namehero = "Gyrocopter";
            Gyrocopter.TypeHero = "Agility";
            Gyrocopter.RangeHero = "Ranged";
            break;

            case "button52":
            namehero = "Hoodwink";
            Hoodwink.TypeHero = "Agility";
            Hoodwink.RangeHero = "Ranged";
            break;

            case "button53":
            namehero = "Juggernaut";
            Juggernaut.TypeHero = "Agility";
            Juggernaut.RangeHero = "Melee";
            break;

            case "button54":
            namehero = "Lone Druid";
            Lone_Druid.TypeHero = "Agility";
            Lone_Druid.RangeHero = "Ranged and Melee";
            break;

            case "button55":
            namehero = "Luna";
            Luna.TypeHero = "Agility";
            Luna.RangeHero = "Ranged";
            break;

            case "button56":
            namehero = "Medusa";
            Medusa.TypeHero = "Agility";
            Medusa.RangeHero = "Ranged";
            break;

            case "button57":
            namehero = "Meepo";
            Meepo.TypeHero = "Agility";
            Meepo.RangeHero = "Melee";
            break;

            case "button58":
            namehero = "Mirana";
            Mirana.TypeHero = "Agility";
            Mirana.RangeHero = "Ranged";
            break;

            case "button59":
            namehero = "Monkey Kinght";
            Monkey_Knight.TypeHero = "Agility";
            Monkey_Knight.RangeHero = "Melee";
            break;

            case "button60":
            namehero = "Morphling";
            Morphling.TypeHero = "Agility";
            Morphling.RangeHero = "Ranged";
            break;

            case "button61":
            namehero = "Naga Siren";
            Naga_Siren.TypeHero = "Agility";
            Naga_Siren.RangeHero = "Melee";
            break;

            case "button62":
            namehero = "Nyx Assassin";
            Nyx_Assassin.TypeHero = "Agility";
            Nyx_Assassin.RangeHero = "Melee";
            break;

            case "button63":
            namehero = "Pangolier";
            Pangolier.TypeHero = "Agility";
            Pangolier.RangeHero = "Melee";
            break;

            case "button64":
            namehero = "Phantom Assassin";
            Phantom_Assassin.TypeHero = "Agility";
            Phantom_Assassin.RangeHero = "Melee";
            break;

            case "button65":
            namehero = "Phantom Lancer";
            Phantom_Assassin.TypeHero = "Agility";
            Phantom_Assassin.RangeHero = "Melee";
            break;

            case "button66":
            namehero = "Razor";
            Razor.TypeHero = "Agility";
            Razor.RangeHero = "Ranged";
            break;

            case "button67":
            namehero = "Riki";
            Riki.TypeHero = "Agility";
            Riki.RangeHero = "Melee";
            break;

            case "button68":
            namehero = "Shadow Fiend";
            Shadow_Fiend.TypeHero = "Agility";
            Shadow_Fiend.RangeHero = "Ranged";
            break;

            case "button69":
            namehero = "Slark";
            Slark.TypeHero = "Agility";
            Slark.RangeHero = "Melee";
            break;

            case "button70":
            namehero = "Sniper";
            Sniper.TypeHero = "Agility";
            Sniper.RangeHero = "Ranged";
            break;

            case "button71":
            namehero = "Spectre";
            Spectre.TypeHero = "Agility";
            Spectre.RangeHero = "Melee";
            break;

            case "button72":
            namehero = "Templar Assassin";
            Templar_Assassin.TypeHero = "Agility";
            Templar_Assassin.RangeHero = "Ranged";
            break;

            case "button73":
            namehero = "Terrorblade";
            Terrorblade.TypeHero = "Agility";
            Terrorblade.RangeHero = "Melee and Ranged";
            break;

            case "button74":
            namehero = "Troll Warlord";
            Troll_Warlord.TypeHero = "Agility";
            Troll_Warlord.RangeHero = "Ranged and Melee";
            break;

            case "button75":
            namehero = "Ursa";
            Ursa.TypeHero = "Agility";
            Ursa.RangeHero = "Melee";
            break;

            case "button76":
            namehero = "Vengeful Spirit";
            Vengeful_Spirit.TypeHero = "Agility";
            Vengeful_Spirit.RangeHero = "Ranged";
            break;

            case "button77":
            namehero = "Venomancer";
            Venomancer.TypeHero = "Agility";
            Venomancer.RangeHero = "Ranged";
            break;

            case "button78":
            namehero = "Viper";
            Viper.TypeHero = "Agility";
            Viper.RangeHero = "Ranged";
            break;

            case "button79":
            namehero = "Weaver";
            Weaver.TypeHero = "Agility";
            Weaver.RangeHero = "Ranged";
            break;

            case "button80":
            namehero = "Ancient Apparition";
            Ancient_Apparition.TypeHero = "Intelligence";
            Ancient_Apparition.RangeHero = "Ranged";
            break;

            case "button81":
            namehero = "Bane";
            Bane.TypeHero = "Intelligence";
            Bane.RangeHero = "Ranged";
            break;

            case "button82":
            namehero = "Batrider";
            Batrider.TypeHero = "Intelligence";
            Batrider.RangeHero = "Ranged";
            break;

            case "button83":
            namehero = "Chen";
            Chen.TypeHero = "Intelligence";
            Chen.RangeHero = "Ranged";
            break;

            case "button84":
            namehero = "Crystal Maiden";
            Crystal_Maiden.TypeHero = "Intelligence";
            Crystal_Maiden.RangeHero = "Ranged";
            break;

            case "button85":
            namehero = "Dark Seer";
            Dark_Seer.TypeHero = "Intelligence";
            Dark_Seer.RangeHero = "Melee";
            break;

            case "button86":
            namehero = "Dark Willow";
            Dark_Willow.TypeHero = "Intelligence";
            Dark_Willow.RangeHero = "Ranged";
            break;

            case "button87":
            namehero = "Dazzle";
            Dazzle.TypeHero = "Intelligence";
            Dazzle.RangeHero = "Ranged";
            break;

            case "button88":
            namehero = "Death Prophet";
            Death_Prophet.TypeHero = "Intelligence";
            Death_Prophet.RangeHero = "Ranged";
            break;

            case "button89":
            namehero = "Disruptor";
            Disruptor.TypeHero = "Intelligence";
            Disruptor.RangeHero = "Ranged";
            break;

            case "button90":
            namehero = "Enchantress";
            Enchantress.TypeHero = "Intelligence";
            Enchantress.RangeHero = "Ranged";
            break;

            case "button91":
            namehero = "Enigma";
            Enigma.TypeHero = "Intelligence";
            Enigma.RangeHero = "Ranged";
            break;

            case "button92":
            namehero = "Grimstroke";
            Grimstroke.TypeHero = "Intelligence";
            Grimstroke.RangeHero = "Ranged";
            break;

            case "button93":
            namehero = "Invoker";
            Invoker.TypeHero = "Intelligence";
            Invoker.RangeHero = "Ranged";
            break;

            case "button94":
            namehero = "Jakiro";
            Jakiro.TypeHero = "Intelligence";
            Jakiro.RangeHero = "Ranged";
            break;

            case "button95":
            namehero = "Keeper of the Light";
            Keeper_of_the_Light.TypeHero = "Intelligence";
            Keeper_of_the_Light.RangeHero = "Ranged";
            break;

            case "button96":
            namehero = "Leshrac";
            Leshrac.TypeHero = "Intelligence";
            Leshrac.RangeHero = "Ranged";
            break;

            case "button97":
            namehero = "Lich";
            Lich.TypeHero = "Intelligence";
            Lich.RangeHero = "Ranged";
            break;

            case "button98":
            namehero = "Lina";
            Lina.TypeHero = "Intelligence";
            Lina.RangeHero = "Ranged";
            break;

            case "button99":
            namehero = "Lion";
            Lion.TypeHero = "Intelligence";
            Lion.RangeHero = "Ranged";
            break;

            case "button100":
            namehero = "Nature's Prophet";
            Nature_s_Prophet.TypeHero = "Intelligence";
            Nature_s_Prophet.RangeHero = "Ranged";
            break;

            case "button101":
            namehero = "Necrophos";
            Necrophos.TypeHero = "Intelligence";
            Necrophos.RangeHero = "Ranged";
            break;

            case "button102":
            namehero = "Ogre Magi";
            Ogre_Magi.TypeHero = "Intelligence";
            Ogre_Magi.RangeHero = "Melee";
            break;

            case "button103":
            namehero = "Oracle";
            Oracle.TypeHero = "Intelligence";
            Oracle.RangeHero = "Ranged";
            break;

            case "button104":
            namehero = "Outword Destroyer";
            Outword_Destroyer.TypeHero = "Intelligence";
            Outword_Destroyer.RangeHero = "Ranged";
            break;

            case "button105":
            namehero = "Puck";
            Puck.TypeHero = "Intelligence";
            Puck.RangeHero = "Ranged";
            break;

            case "button106":
            namehero = "Pugna";
            Pugna.TypeHero = "Intelligence";
            Pugna.RangeHero = "Ranged";
            break;

            case "button107":
            namehero = "Queen of Pain";
            Queen_of_Pain.TypeHero = "Intelligence";
            Queen_of_Pain.RangeHero = "Ranged";
            break;

            case "button108":
            namehero = "Rubick";
            Rubick.TypeHero = "Intelligence";
            Rubick.RangeHero = "Ranged";
            break;

            case "button109":
            namehero = "Shadow Demon";
            Shadow_Demon.TypeHero = "Intelligence";
            Shadow_Demon.RangeHero = "Ranged";
            break;

            case "button110":
            namehero = "Shadow Shaman";
            Shadow_Shaman.TypeHero = "Intelligence";
            Shadow_Shaman.RangeHero = "Ranged";
            break;

            case "button111":
            namehero = "Silencer";
            Silencer.TypeHero = "Intelligence";
            Silencer.RangeHero = "Ranged";
            break;

            case "button112":
            namehero = "Skywrath Magi";
            Skywrath_Magi.TypeHero = "Intelligence";
            Skywrath_Magi.RangeHero = "Ranged";
            break;

            case "button113":
            namehero = "Storm Spirit";
            Storm_Spirit.TypeHero = "Intelligence";
            Storm_Spirit.RangeHero = "Ranged";
            break;

            case "button114":
            namehero = "Techies";
            Techies.TypeHero = "Intelligence";
            Techies.RangeHero = "Ranged";
            break;

            case "button115":
            namehero = "Tinker";
            Tinker.TypeHero = "Intelligence";
            Tinker.RangeHero = "Ranged";
            break;

            case "button116":
            namehero = "Visage";
            Visage.TypeHero = "Intelligence";
            Visage.RangeHero = "Ranged";
            break;

            case "button117":
            namehero = "Void Spirit";
            Void_Spirit.TypeHero = "Intelligence";
            Void_Spirit.RangeHero = "Melee";
            break;

            case "button118":
            namehero = "Warlock";
            Warlock.TypeHero = "Intelligence";
            Warlock.RangeHero = "Ranged";
            break;

            case "button119":
            namehero = "Windranger";
            Windranger.TypeHero = "Intelligence";
            Windranger.RangeHero = "Ranged";
            break;

            case "button120":
            namehero = "Winter Wyvern";
            Winter_Wyvern.TypeHero = "Intelligence";
            Winter_Wyvern.RangeHero = "Ranged";
            break;

            case "button121":
            namehero = "Witch Doctor";
            Witch_Doctor.TypeHero = "Intelligence";
            Witch_Doctor.RangeHero = "Ranged";
            break;

            case "button122":
            namehero = "Zeus";
            Zeus.TypeHero = "Intelligence";
            Zeus.RangeHero = "Ranged";
            break;
        }
    }
    public static string verdb(string namehero)
    {
        string temp = "";
        return temp;
    }
    public static void Alert(string msg, frmAlert.alertTypeEnum type)
    {
        frmAlert f = new frmAlert();
        f.setAlert(msg, type);
    }
}
