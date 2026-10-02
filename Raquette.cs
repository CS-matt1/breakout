using Raylib_cs;
using static Raylib_cs.Raylib;

namespace Breakout;

static partial class Program
{
    /// <summary>Le rectangle occupé par la raquette à l'écran.</summary>
    static Rectangle RectangleRaquette()
    {
        return new Rectangle(positionRaquette.X, positionRaquette.Y, LARGEUR_RAQUETTE, HAUTEUR_RAQUETTE);
    }

    /// <summary>Déplace la raquette avec les flèches, sans sortir de la fenêtre.</summary>
    static void DeplacerRaquette(float dt)
    {
        if (Raylib.IsKeyDown(KeyboardKey.Left))
        {
            positionRaquette.X -= VITESSE_RAQUETTE * dt;
            positionRaquette.X = Math.Clamp(positionRaquette.X, 0, LARGEUR - 80);
        }
        if (Raylib.IsKeyDown(KeyboardKey.Right))
        {
            positionRaquette.X += VITESSE_RAQUETTE * dt;
            positionRaquette.X = Math.Clamp(positionRaquette.X, 0, LARGEUR - 100);
        }
    }

    /// <summary>Fait rebondir la balle si elle touche la raquette.</summary>
    static void RebondirSurRaquette()
    {
        
            //if ((positionRaquette.X >= (LARGEUR - RAYON_BALLE)) || (positionRaquette.X <= RAYON_BALLE))
            //{
            //    vitesseBalle.X *= -1.0f;
            //}

            //// Collision Haut et Bas (Axe Y)
            //if ((positionRaquette.Y == (HAUTEUR - RAYON_BALLE)) || (positionRaquette.Y == RAYON_BALLE))
            //{
            //    vitesseBalle.Y *= -1.0f;
            //}
        


            if (Raylib.CheckCollisionCircleRec(positionBalle, RAYON_BALLE, RectangleRaquette()))
            {
                // Inversion simple de la vitesse verticale en cas de collision
                vitesseBalle.Y *= -vitesseBalle.Y;
            }
        


    }


}
