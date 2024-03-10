﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using Forza_Mods_AIO.Cheats.ForzaHorizon5;
using Forza_Mods_AIO.ViewModels.SubPages.SelfVehicle;
using MahApps.Metro.Controls;
using static Forza_Mods_AIO.Resources.Memory;

namespace Forza_Mods_AIO.Views.SubPages.SelfVehicle;

public partial class Misc
{
    public Misc()
    {
        ViewModel = new MiscViewModel();
        DataContext = this;
        
        InitializeComponent();
    }

    public MiscViewModel ViewModel { get; }
    private static MiscCheats MiscCheatsFh5 => Forza_Mods_AIO.Resources.Cheats.GetClass<MiscCheats>();
    
    private async void NameSpooferSwitch_OnToggled(object sender, RoutedEventArgs e)
    {
        if (sender is not ToggleSwitch toggleSwitch)
        {
            return;
        }

        ViewModel.SpooferUiElementsEnabled = false;
        if (MiscCheatsFh5.NameDetourAddress == 0)
        {
            await MiscCheatsFh5.CheatName();
        }
        ViewModel.SpooferUiElementsEnabled = true;

        if (MiscCheatsFh5.NameDetourAddress == 0) return;
        GetInstance().WriteMemory(MiscCheatsFh5.NameDetourAddress + 0x5E, toggleSwitch.IsOn ? (byte)1 : (byte)0);
        if (string.IsNullOrEmpty(NameBox.Text)) return;
        var name = Encoding.Unicode.GetBytes(NameBox.Text);
        var newName = new byte[64];
        Array.Copy(name, newName, Math.Min(name.Length, newName.Length));
        GetInstance().WriteArrayMemory(MiscCheatsFh5.NameDetourAddress + 0x5F, newName);
    }

    private void NameBox_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        if (MiscCheatsFh5.NameDetourAddress == 0) return;
        if (string.IsNullOrEmpty(NameBox.Text)) return;
        var name = Encoding.Unicode.GetBytes(NameBox.Text);
        var newName = new byte[64];
        Array.Copy(name, newName, Math.Min(name.Length, newName.Length));
        GetInstance().WriteArrayMemory(MiscCheatsFh5.NameDetourAddress + 0x5F, newName);
    }
}