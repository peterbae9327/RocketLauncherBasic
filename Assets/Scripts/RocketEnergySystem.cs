using UnityEngine;
using UnityEngine.UI;

public class RocketEnergySystem : Rocket//연료충전담당
{
    private float fuel = 100f;
    private readonly float FUELPERSHOOT = 10f;//to RocketEnergySystem
    [SerializeField] private Image FuelBar;//to RocketDashboard
    private void Update()
    {
        if(fuel <= 100)
        {
            fuel += 0.1f;
        }
        FuelBar.fillAmount = fuel / 100f;
    }
    public void Shoot()
    {
        if(fuel >= FUELPERSHOOT)
        {
            AddForce();
            fuel -= FUELPERSHOOT;
        }
    }
}
