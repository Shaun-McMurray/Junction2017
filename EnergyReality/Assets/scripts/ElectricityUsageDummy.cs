using UnityEngine;

public class ElectricityUsageDummy : MonoBehaviour {

    float electricalOutput;

	

    public float ElectricalUsagePerYear()
    {
        float spriteNumber = 0;
        float electricalOutput = Random.Range(0, 5000);
        if (electricalOutput < 500)
        {
            return spriteNumber = 1;
        }

        if (electricalOutput >= 500 && electricalOutput < 3000)
        {
            return spriteNumber = 2;
        } else
        {
            return spriteNumber = 3;
        }
    }
}
