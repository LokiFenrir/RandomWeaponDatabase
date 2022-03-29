using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponDatabase : MonoBehaviour
{

    // Vars

    public List<Weapon> _weapons = new List<Weapon>();

    public string _weaponName;

    public List<GameObject> _objs;

    public Transform _arm1;
    public Transform _arm2;

    public Text _text1;
    public Text _text2;

    // Functions

    private void Awake()
    {



    }

    private void Start()
    {



    }//Awake

    private void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.W))
        {

            if (_arm1.childCount > 0)
                Destroy(_arm1.transform.GetChild(0).gameObject);
            if (_arm2.childCount > 0)
                Destroy(_arm2.transform.GetChild(0).gameObject);

            Arm1();
            Arm2();

        }


    }//Update


    public void Arm1()
    {

        BuildWeaponDatabase();
        GetWeapon();

        if (_weaponName == "Wooden Sword")
        {

            Debug.Log("Sword");
            Instantiate(Resources.Load("Sword", typeof(GameObject)) as GameObject, _arm1);
            _text1.text = _weaponName;

        }
        else if (_weaponName == "Wooden Spear")
        {

            Debug.Log("Spear");
            Instantiate(Resources.Load("Spear", typeof(GameObject)) as GameObject, _arm1);
            _text1.text = _weaponName;

        }
        else if (_weaponName == "Wooden Dagger")
        {

            Debug.Log("Dagger");
            Instantiate(Resources.Load("Dagger", typeof(GameObject)) as GameObject, _arm1);
            _text1.text = _weaponName;

        }
        else if (_weaponName == "Slingshot")
        {

            Debug.Log("Slighshot");
            Instantiate(Resources.Load("SlightShot", typeof(GameObject)) as GameObject, _arm1);
            _text1.text = _weaponName;

        }
        else if (_weaponName == "Dark Blade")
        {

            Debug.Log("Dark Blade");
            Instantiate(Resources.Load("DarkSword", typeof(GameObject)) as GameObject, _arm1);
            _text1.text = _weaponName;

        }

    }


    public void Arm2()
    {

        BuildWeaponDatabase();
        GetWeapon();

        if (_weaponName == "Wooden Sword")
        {

            Debug.Log("Sword");
            Instantiate(Resources.Load("Sword", typeof(GameObject)) as GameObject, _arm2);
            _text2.text = _weaponName;

        }
        else if (_weaponName == "Wooden Spear")
        {

            Debug.Log("Spear");
            Instantiate(Resources.Load("Spear", typeof(GameObject)) as GameObject, _arm2);
            _text2.text = _weaponName;

        }
        else if (_weaponName == "Wooden Dagger")
        {

            Debug.Log("Dagger");
            Instantiate(Resources.Load("Dagger", typeof(GameObject)) as GameObject, _arm2);
            _text2.text = _weaponName;

        }
        else if (_weaponName == "Slingshot")
        {

            Debug.Log("Slighshot");
            Instantiate(Resources.Load("SlightShot", typeof(GameObject)) as GameObject, _arm2);
            _text2.text = _weaponName;

        }
        else if (_weaponName == "Dark Blade")
        {

            Debug.Log("Dark Blade");
            Instantiate(Resources.Load("DarkSword", typeof(GameObject)) as GameObject, _arm2);
            _text2.text = _weaponName;

        }

    }

    public Weapon GetWeapon()
    {

        int _generator = Random.Range(0, _weapons.Count);
        _weaponName = (_weapons[_generator]._title);
        return _weapons[_generator];

    }//GetItem


    void BuildWeaponDatabase()
    {

        _weapons = new List<Weapon>()
        {

            new Weapon("Wooden Sword", "Sword", "Just a wooden sword can't even cut me", Resources.Load("Sword", typeof(GameObject)) as GameObject, 2, 5),
            new Weapon("Wooden Spear", "Spear", "Just a spear of wood", Resources.Load("Spear", typeof(GameObject)) as GameObject, 3, 3),
            new Weapon("Wooden Dagger", "Dagger", "Just a dagger that kids play with", Resources.Load("Dagger", typeof(GameObject)) as GameObject, 1, 8),
            new Weapon("Slingshot", "Gun", "Used with rock to hurt everyone", Resources.Load("Slingshot", typeof(GameObject)) as GameObject, 2, 10),
            new Weapon("Dark Blade", "Sword", "Sword of darkness", Resources.Load("Dark Blade", typeof(GameObject)) as GameObject, 10, 10)

        };

    }//BuildWeaponDatabase

}
