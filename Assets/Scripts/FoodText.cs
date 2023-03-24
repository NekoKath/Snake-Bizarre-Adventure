using UnityEngine;

public class FoodText : MonoBehaviour
{
    public Food Food;
    public TextMesh Text;
    
    void Update()
    {
        Text.text = Food.HPFood.ToString();
    }
}
