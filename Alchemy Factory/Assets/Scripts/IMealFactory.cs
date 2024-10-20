using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMealFactory
{
    IMeal Create(MealRequirements requirements);
}

public class OvenFactory : IMealFactory
{
    public IMeal Create(MealRequirements requirements)
    {
        switch (requirements.mealType)
        {
            case MealType.snack:
                if (requirements.flavorType == FlavorType.sweet)
                    return new Cookie();
                else
                    return new GarlickBread();
            case MealType.meal:
                if (requirements.flavorType == FlavorType.sweet)
                    return new Cake();
                else
                    return new Pizza();
            default:
                return new Pizza();
        }
    }
}

public class MicrowaveFactory : IMealFactory
{
    public IMeal Create(MealRequirements requirements)
    {
        switch (requirements.mealType)
        {
            case MealType.snack:
                if (requirements.flavorType == FlavorType.sweet)
                    return new Brownie();
                else
                    return new Nuggets();
            case MealType.meal:
                if (requirements.flavorType == FlavorType.sweet)
                    return new IceCream();
                else
                    return new MacNCheese();
            default:
                return new MacNCheese();
        }
    }
}

public class SewerFactory : IMealFactory
{
    public IMeal Create(MealRequirements requirements)
    {
        switch (requirements.mealType)
        {
            case MealType.snack:
                if (requirements.flavorType == FlavorType.sweet)
                    return new Waste();
                else
                    return new Fungus();
            case MealType.meal:
                if (requirements.flavorType == FlavorType.sweet)
                    return new Rock();
                else
                    return new Rat();
            default:
                return new Rat();
        }
    }
}


public abstract class AbstractVehicleFactory
{
    public abstract IMeal Create();
}



public class VehicleFactory : AbstractVehicleFactory
{
    private readonly IMealFactory _factory;
    private readonly MealRequirements _requirements;

    public VehicleFactory(MealRequirements requirements)
    {
        switch (requirements.equipmentType)
        {
            case EquipmentType.oven:
                _factory = new OvenFactory();
                break;
            case EquipmentType.microwave:
                _factory = new MicrowaveFactory();
                break;
            case EquipmentType.sewer:
                _factory = new SewerFactory();
                break;
        }
        _requirements = requirements;
    }

    public override IMeal Create()
    {
        return _factory.Create(_requirements);
    }
}

