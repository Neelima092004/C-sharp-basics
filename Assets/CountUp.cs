using UnityEngine;
using TMPro;
public class CountUp : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI Text;
    [SerializeField]
    private float Speed = 1;
    private float TimeDisplay = 0;
  
     void Update()
    {
        if(Speed>0)
        
            {
                TimeDisplay = TimeDisplay + Time.deltaTime * Speed;
            Text.SetText(TimeDisplay.ToString());
            }
    }
}
