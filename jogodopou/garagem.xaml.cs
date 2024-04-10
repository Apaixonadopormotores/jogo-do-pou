using Microsoft.Maui.Controls;

namespace jogodopou;

public class garagem()
{
    double gasolina = 0;
    double oleo = 0;
    double turbo = 0;
    protected string fotodocarro;

public string getfotodocarro()
{
    return fotodocarro;
}
    public double Getgasolina()
    {
        return gasolina;
    }
    public double Getoleo()
    {
    return oleo;
    } 
    public double getturbo()
    {
        return turbo;
    }

    public void Setgasolina(double g)
    {
        if (g < 0)
        {
            gasolina = 0;
        }
        else if (g > 1)
        {
            gasolina = 1;
         
        }
        else
        {
            gasolina = g;
        }

    }

    public void setturbo (double t)
            {
                if(t < 0)
                {
                    turbo = 0;
                }
                else if (t > 1)
                {
                    turbo = 1;
                }
                else
                {
                    turbo = t;
                }
            }


    public void Setoleo (double o)
        {
            if (o < 0)
            {
                oleo = 0;
            }
            else if (o > 1)
            {
                oleo = 1;
            }
            else
            {
                oleo = o;
            }
            
        }
}
