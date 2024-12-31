## Ce que j'avais écrit
Le Liasse est une interface qui a en signature LiasseClient et LiasseVierge, LiasseClient sert à créer des documents et les afficher et LiasseVierge sert à ajouter et retirer des document. Aussi Document fait référence a Liasse pour récupérer les documents et document a en signature BonDeCommande, DemandeImmatriculation et CertificatCession. Document est une classe abstraite et il sert a dupliquer les documents. Et les 3 methode relier a Document sert a afficher les documents

## Correction

Le design pattern prototype permet de créer des copies d'objets existant sans rendre le code dépendant de leur classes concrétes. Au lieu de créer un objet a partir de zero, on clone un objet existant (le prototype) et on le modifie si besoin.
C'est comme faire une photocopie d'un document : on copie l'original et on peut modifier la copie
L'avantage principale est la création d'objet complexe simplifiées.
Cas d'usage :
    Objets avec de nombreuses configuration (editeur graphique : forme geometriques)
    En jeux video, creation d'enemis et leur variable en grande quantité
    Creation d'une configuration par defaut dans un jeu/logiciel (permet de restaurer le defaut rapidement et de configurer a nouveau)
    Pour eviter la creation d'objets systemes couteux ; connexion reseaux, ressources partagées ....