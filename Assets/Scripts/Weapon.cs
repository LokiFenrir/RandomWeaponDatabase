using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Weapon
{

    public string _title;
    public string _type;
    public string _description;
    public GameObject _weaponObj;
    public int _power;
    public int _stamina;

    public Weapon(string _title, string _type, string _description, GameObject _weaponObj, int _power, int _stamina)
    {

        this._title = _title;
        this._type = _type;
        this._description = _description;
        this._weaponObj = _weaponObj;
        this._power = _power;
        this._stamina = _stamina;

    }//Weapon


    public Weapon(Weapon _weapon)
    {

        this._title = _weapon._title;
        this._type = _weapon._type;
        this._description = _weapon._description;
        this._weaponObj = _weapon._weaponObj;
        this._power = _weapon._power;
        this._stamina = _weapon._stamina;

    }//Weapon

}// Weapon
