public enum EquipmentType
{
    oven,
    microwave,
    sewer
}

public enum MealType
{
    snack,
    meal,
}

public enum FlavorType
{
    sweet,
    savory
}


public class MealRequirements
{
    public EquipmentType equipmentType;
    public MealType mealType;
    public FlavorType flavorType;
}