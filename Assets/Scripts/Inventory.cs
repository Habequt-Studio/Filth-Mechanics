using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject flashlightHolder;
    public GameObject weaponHolder;

    public KeyCode weaponSwitchKey = KeyCode.Keypad2;
    public KeyCode handKey = KeyCode.Keypad1;
    public KeyCode flashlightKey = KeyCode.Keypad2;

    public Image flashLighSprite;
    public Image weaponSprite;
    public GameObject inventoryPanel;

    public Color inactiveBackgroundColor;
    public Color activeBackgroundColor;

    private int currentInvSlot = 0; //0 - flashlight; 1 - weapon
    private int maxInvSlot = 1;

    private float inventoryTimer = 0;

    private void Start()
    {
        flashlightHolder.SetActive(true);
        weaponHolder.SetActive(false);
        inventoryPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            currentInvSlot++;
            if (currentInvSlot > maxInvSlot)
            {
                currentInvSlot = maxInvSlot;
            }
            UpdateColors();
            ShowInventory();
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            currentInvSlot--;
            if (currentInvSlot < 0)
            {
                currentInvSlot = 0;
            }
            UpdateColors();
            ShowInventory();
        }

        if (Input.GetMouseButtonDown(0) && inventoryPanel.activeSelf)
        {
            UpdateWeaponSlots();
        }

        if (inventoryPanel.activeSelf)
        {
            inventoryTimer -= Time.deltaTime;
            if (inventoryTimer > 0)
            {
                inventoryPanel.SetActive(true);
            } else
            {
                inventoryPanel.SetActive(false);
                inventoryTimer = 0.0f;
            }
        }
    }

    private void UpdateColors()
    {
        switch (currentInvSlot)
        {
            case 0:
                flashLighSprite.color = activeBackgroundColor;
                weaponSprite.color = inactiveBackgroundColor;
                break;
            case 1:
                flashLighSprite.color = inactiveBackgroundColor;
                weaponSprite.color = activeBackgroundColor;
                break;
        }
    }

    private void ShowInventory()
    {
        inventoryTimer = 4.0f;
        inventoryPanel.SetActive(true);
    }

    //update current weapon by current inventory index
    private void UpdateWeaponSlots()
    {
        inventoryPanel.SetActive(true);
        switch (currentInvSlot)
        {
            case 0:
                SetFlashlight(true);
                SetWeapon(false);
                break;
            case 1:
                SetWeapon(true);
                SetFlashlight(false);
                break;
        }
        inventoryTimer = 0.0f;
    }

    void SetWeapon(bool active)
    {
        weaponHolder.SetActive(active);
    }

    void SetFlashlight(bool active)
    {
        flashlightHolder.SetActive(active);
    }
}
