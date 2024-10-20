using UnityEngine;

public interface IMeal
{
    public string GetDescription();
    public string GetName();
    public GameObject GetPrefab();
}

#region Oven Foods
public class Cookie : IMeal
{
    public string GetDescription()
    {
        return "Contains nuts.";
    }

    public string GetName()
    {
        return "Cookie";
    }

    public GameObject GetPrefab()
    {
        return Resources.Load("Cookie") as GameObject;
    }
}

public class GarlickBread : IMeal
{
    public string GetDescription()
    {
        return "a savory toasted slice of bread spread with garlick butter.";
    }

    public string GetName()
    {
        return "Garlick Bread";
    }

    public GameObject GetPrefab()
    {
        return Resources.Load("GarlickBread") as GameObject;
    }
}
public class Cake : IMeal
{
    public string GetDescription()
    {
        return "You're not gonna put it in the fridge first?";
    }

    public string GetName()
    {
        return "Cake";
    }

    public GameObject GetPrefab()
    {
        return Resources.Load("Cake") as GameObject;
    }
}
public class Pizza : IMeal
{
    public string GetDescription()
    {
        return "A whole 20 inch pizza just for you.\nYou should feel bad about yourself!";
    }

    public string GetName()
    {
        return "Pizza";
    }

    public GameObject GetPrefab()
    {
        return Resources.Load("Pizza") as GameObject;
    }
}

#endregion

#region Microwave Foods
public class Brownie : IMeal
{
    public GameObject GetPrefab()
    {
        return Resources.Load("Brownie") as GameObject;
    }

    public string GetDescription()
    {
        return "Easy bake brownies!\nThey're inedible because you microwaved them for 20 MINUTES!";
    }

    public string GetName()
    {
        return "Easy Bake Brownie";
    }
}
public class Nuggets : IMeal
{
    public GameObject GetPrefab()
    {
        return Resources.Load("Nuggets") as GameObject;
    }
    public string GetDescription()
    {
        return "An american classic.\nTry something more nutritious next time.";
    }

    public string GetName()
    {
        return "Microwave Chicken Nuggets";
    }
}
public class IceCream : IMeal
{
    public GameObject GetPrefab()
    {
        return Resources.Load("IceCream") as GameObject;
    }
    public string GetDescription()
    {
        return "A whole pint of ice cream.\nYou were trying to soften it but forgot to take it out. it's ruined.";
    }

    public string GetName()
    {
        return "1 Pint Of Ice Cream?";
    }
}
public class MacNCheese : IMeal
{
    public GameObject GetPrefab()
    {
        return Resources.Load("MacAndCheese") as GameObject;
    }
    public string GetDescription()
    {
        return "A bowl of Mac and Cheese. How creative!";
    }

    public string GetName()
    {
        return "Mac And Cheese";
    }
}

#endregion

#region Sewer Foods
public class Waste : IMeal
{
    public GameObject GetPrefab()
    {
        return Resources.Load("Waste") as GameObject;
    }
    public string GetDescription()
    {
        return "A delicious cup of [REDACTED].\nNot to be consumed in large quantities.";
    }

    public string GetName()
    {
        return "Cup of toxic waste.";
    }
}
public class Fungus : IMeal
{
    public GameObject GetPrefab()
    {
        return Resources.Load("Fungus") as GameObject;
    }
    public string GetDescription()
    {
        return "Last time you ate this you blacked out for 8 days...\n A perfect excuse to get out of plans.";
    }

    public string GetName()
    {
        return "Scary Fungus";
    }
}
public class Rock : IMeal
{
    public GameObject GetPrefab()
    {
        return Resources.Load("Rock") as GameObject;
    }
    public string GetDescription()
    {
        return "The stone is radiating an uncomfortable dry heat.\nRated safe to consume by 9/10 experts!";
    }

    public string GetName()
    {
        return "Big Shiny Glowing Rock";
    }
}
public class Rat : IMeal
{
    public GameObject GetPrefab()
    {
        return Resources.Load("Rat") as GameObject;
    }
    public string GetDescription()
    {
        return "This one isn't gonna take it lying down. Good luck!";
    }

    public string GetName()
    {
        return "30lb live rat";
    }
}
#endregion

