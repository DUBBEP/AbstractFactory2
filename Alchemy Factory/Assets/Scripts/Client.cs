using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    MealRequirements _mealRequirements = new MealRequirements();

    public TextMeshProUGUI flavorText;
    public TextMeshProUGUI mealName;
    public Transform displayPosition;

    private GameObject curFood;

    public GameObject ovenHighlight;
    public GameObject microwaveHighlight;
    public GameObject sewerHighlight;

    private float displayTime = 0;
    bool displayActive = false;

    void Start()
    {
        SetHighlight(null);

        _mealRequirements.equipmentType = EquipmentType.oven;
        _mealRequirements.mealType = MealType.snack;
        _mealRequirements.flavorType = FlavorType.sweet;
    }
    void Update()
    {
        if (displayTime > 0 && displayActive)
            displayTime -= Time.deltaTime;

        if (displayTime <= 0 && displayActive)
        {
            DisplayFood(null);   
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            bool hasHit = Physics.Raycast(ray, out hit);

            if (hasHit)
            {
                switch (hit.transform.tag)
                {
                    case "oven":
                        SetHighlight("oven");
                        _mealRequirements.equipmentType = EquipmentType.oven;
                        break;
                    case "microwave":
                        SetHighlight("microwave");
                        _mealRequirements.equipmentType = EquipmentType.microwave;
                        break;
                    case "sewer":
                        SetHighlight("sewer");
                        _mealRequirements.equipmentType = EquipmentType.sewer;
                        break;
                }
            }
        }
    }

    public void OnCookMeal()
    {
        IMeal v = GetVehicle(_mealRequirements);

        DisplayFood(v);
    }

    void DisplayFood(IMeal v)
    {
        if (v == null)
        {
            mealName.text = "";
            flavorText.text = "";
            Destroy(curFood);
            displayActive = false;
            displayTime = 0;
            return;
        }

        displayActive = true;
        displayTime = 15;

        if (curFood != null)
            Destroy(curFood);

        GameObject prefab = v.GetPrefab();

        mealName.text = v.GetName();
        flavorText.text = v.GetDescription();
        curFood = Instantiate(prefab, displayPosition.position, prefab.transform.rotation);
    }

    public void UpdateFlavor(TMP_Dropdown dropdown)
    {
        if (dropdown.value == 0)
            _mealRequirements.flavorType = FlavorType.sweet;
        else if (dropdown.value == 1)
            _mealRequirements.flavorType = FlavorType.savory;
    }    
    public void UpdateMealType(TMP_Dropdown dropdown)
    {
        if (dropdown.value == 0)
            _mealRequirements.mealType = MealType.snack;
        else if (dropdown.value == 1)
            _mealRequirements.mealType = MealType.meal;
    }

    static IMeal GetVehicle(MealRequirements requirements)
    {
        VehicleFactory factory = new VehicleFactory(requirements);
        return factory.Create();
    }

    void SetHighlight(string tool)
    {
        ovenHighlight.SetActive(false);
        microwaveHighlight.SetActive(false);
        sewerHighlight.SetActive(false);

        if (tool == null)
            return;

        switch (tool)
        {
            case "oven":
                ovenHighlight.SetActive(true);
                break;
            case "microwave":
                microwaveHighlight.SetActive(true);
                break;
            case "sewer":
                sewerHighlight.SetActive(true);
                break;
        }
    }

    /*
    IEnumerator ThrowMessage(string message)
    {
        Debug.Log("Throwing Message");
        numOfMessages++;
        int i = 0;
        while (i < numOfMessages)
        {
            {
                notificationText.text = notificationText.text + "\n" + message;
                yield return new WaitForSeconds(3);

                if (i == numOfMessages)
                    ++i;
                else
                {
                    notificationText.text = "";
                    numOfMessages = 0;
                }
            }
        }
    }
    */

}