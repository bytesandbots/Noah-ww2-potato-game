using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;
public class UnitSpawn : MonoBehaviour
{
    public int money;
    public List<GameObject> units = new List<GameObject>();
    public List<int> prices = new List<int>();

    public Transform defensivePosition;
    public Text moneytext;
    public Button tankButton;
    public Button soldierButton;
    public Button bazookaButton;
    public Button attackButton;
    public Button defendButton;
    public Button retreatButton;
    void Start()
    {
        money = 20;
        StartCoroutine(MONEY());
        tankButton.onClick.AddListener(() => SpawnUnit(units[0], prices[0]));
        soldierButton.onClick.AddListener(() => SpawnUnit(units[1], prices[1]));
        bazookaButton.onClick.AddListener(() => SpawnUnit(units[2], prices[2]));
        attackButton.onClick.AddListener(Attack);
        defendButton.onClick.AddListener(Defend);
        retreatButton.onClick.AddListener(Retreat);
    }
    void Update()
    {
        moneytext.text=money.ToString();
        NullChecker();
    }

    void SpawnUnit(GameObject unit, int price)
    {
        if (money >= price)
        {
            Instantiate(unit, transform.position + new Vector3(0, -0.81f, 0), Quaternion.identity);
            money -= price;
        }
    }

        void Retreat()
    {
        for (int i = 0; i < units.Count; ++i)
        {
            units[i].GetComponent<Movement>().currentState = Movement.State.Retreating;
        }
    }

    void Attack()
    {
        for (int i = 0; i < units.Count; ++i)
        {
            units[i].GetComponent<Movement>().currentState = Movement.State.Attacking;
        }
    }

    void Defend()
    {
        for (int i = 0; i < units.Count; ++i)
        {
            units[i].GetComponent<Movement>().currentState = Movement.State.Defending;
        }
    }
    void NullChecker()
    {
        for (int i = 0; i < units.Count; ++i)
        {
            if (units[i] == null) units.Remove(units[i]);
        }
    }

    IEnumerator MONEY()
    {
        while(true) 
        {
             yield return new WaitForSeconds(1f);
            money += 1;
        }
       
    }
}



