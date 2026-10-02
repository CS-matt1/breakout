using Raylib_cs;
using System.Numerics;

namespace Breakout;

static partial class Program
{
    /// <summary>Pose la balle au milieu du dessus de la raquette.</summary>
    static void CollerBalleARaquette()
    {
            positionBalle.X = positionRaquette.X + LARGEUR_RAQUETTE /2;
            positionBalle.Y = positionRaquette.Y - HAUTEUR_RAQUETTE;

    }

    /// <summary>Donne à la balle sa vitesse de départ.</summary>
    static void LancerBalle()
    {
        vitesseBalle = new Vector2(VITESSE_BALLE, VITESSE_BALLE);
    }

    /// <summary>Avance la balle selon sa vitesse.</summary>
    static void DeplacerBalle(float dt)
    {
        positionBalle.X -= vitesseBalle.X * dt;
        positionBalle.Y -= vitesseBalle.Y * dt;
    }

    /// <summary>Fait rebondir la balle sur les murs gauche, droit et haut.</summary>
    static void RebondirSurMurs()
    {
    
        if ((positionBalle.X >= (LARGEUR - RAYON_BALLE)) || (positionBalle.X <= RAYON_BALLE))
        {
            vitesseBalle.X *= -1.0f;
        }

        // Collision Haut et Bas (Axe Y)
        if ((positionBalle.Y >= (HAUTEUR - RAYON_BALLE)) || (positionBalle.Y <= RAYON_BALLE))
        {
            vitesseBalle.Y *= -1.0f;
        }
    }

    /// <summary>Indique si la balle est entièrement sortie par le bas de la fenêtre.</summary>
    static bool BalleSortieEnBas()
    {
        //if (positionBalle.Y + RAYON_BALLE >= HAUTEUR)
        //{
        //    etat = EtatJeu.Perdu;
        //}
        return false;
    }
}
