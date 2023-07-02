using PropertyChanged;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using UnitsNet;

namespace MauiVerter.ViewModels;


[AddINotifyPropertyChangedInterface]
public class ConverterViewModel
{

    public ConverterViewModel(string quantityName)
    {
        QuantityName = quantityName;
        FromMeasures = LoadMeasures();
        ToMeasures = LoadMeasures();
        CurrentFromMeasure = FromMeasures.FirstOrDefault();
        CurrentToMeasure = ToMeasures.Skip(1).FirstOrDefault();
    }

    public string QuantityName { get; set; }
    public string CurrentFromMeasure { get; set; }
    public string CurrentToMeasure { get; set; }
    public double FromValue { get; set; } = 1;
    public double ToValue { get; set; }
    public ObservableCollection<string> FromMeasures{ get; set; }
    public ObservableCollection<string> ToMeasures{ get; set; }
    public ICommand ReturnCommand => new Command(() => { Convert(); });

    public void Convert()
    {
        var result = UnitConverter.ConvertByName(FromValue,QuantityName,CurrentFromMeasure,CurrentToMeasure);
        ToValue = result;
    }


    public ObservableCollection<string> LoadMeasures()
    {
        var types = Quantity.Infos.FirstOrDefault(x=>x.Name == QuantityName).UnitInfos.Select(x => x.Name).ToList();

        return new ObservableCollection<string>(types);
    }

}
