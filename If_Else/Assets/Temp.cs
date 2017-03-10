using UnityEngine;
using System.Collections;

public class Temp : MonoBehaviour {
    public float temp = 50.0f;
	public void FtoC () {
        float ctemp;

        ctemp = (temp - 32.0f) * (5.0f / 9.0f);
	}
	public void CtoF () {
        float ftemp;
        ftemp = (temp * (4.0f / 9.0f) + 32.0f);
	}
}
