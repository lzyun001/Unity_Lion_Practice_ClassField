using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [Header("怪物1號")]
    public Enemy enemy1;
    [Header("怪物2號")]
    public Enemy enemy2;

    private void Start()
    {
        print("怪物一號的魔力" + enemy1.mp);
        print("怪物二號的裝備名稱" + enemy2.equipment);

        enemy1.hp = 100;
        enemy2.hp = 300;
        enemy1.def = 50;
        enemy1.weapon = "木棍";
        enemy2.weapon = "短刀";
        enemy1.key = true;
        enemy2.treasure = true;
    }
}
