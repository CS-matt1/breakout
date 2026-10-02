using Raylib_cs;

namespace Breakout;

static partial class Program
{
    /// <summary>Le rectangle occupé à l'écran par la brique (ligne, colonne).</summary>
    static Rectangle RectangleBrique(int ligne, int colonne)
    {
        float x = ESPACE_BRIQUES + colonne * (LARGEUR_BRIQUE + ESPACE_BRIQUES);
        float y = MARGE_HAUT_BRIQUES + ligne * (HAUTEUR_BRIQUE + ESPACE_BRIQUES);

        return new Rectangle(x, y, LARGEUR_BRIQUE, HAUTEUR_BRIQUE);
    }

    /// <summary>Casse la brique touchée par la balle, fait rebondir la balle et ajoute les points.</summary>
    static void CasserBriques()
    {
    }

    /// <summary>Le nombre de briques encore présentes.</summary>
    static int CompterBriques()
    {
        return 0;
    }

    /// <summary>Dessine les briques encore présentes, une couleur par ligne.</summary>
    static void DessinerBriques()
    {

        for (int ligne = 0; ligne < LIGNES_BRIQUES; ligne++)
        {
            for (int colonne = 0; colonne < COLONNES_BRIQUES; colonne++)
            {
                if (briques[ligne, colonne])
                {

                    Rectangle rectangle = RectangleBrique(ligne, colonne);
                    Raylib.DrawRectangleRec(rectangle, couleursLignes[ligne]);
                }
            }
        }


    }
}
