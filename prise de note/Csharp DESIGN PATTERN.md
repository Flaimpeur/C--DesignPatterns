
## Chapitre 1

### 1.1              :

Schéma d’objets qui forme une solution à un problème connu et fréquent

Ensemble de classes et de relation

Dans le cadre de la POO

Bases sur les bonnes pratiques

Exemple template shema pattern design (shéma UML)

### 1.2 Description des patterns de conception

Le langage est UML et le C# (et bien d’autre comme java …)

Pour chaque pattner on aura :

-            Le nom

-            Description

-            Exemple sous forme UML

-            Structure générique du pattern

-            Le cas d’utilisation

-            Exemple de code en C#

-            (Pour nous, liens vers refactoring guru)

## Chapitre 2. Une étude de cas, la vente en ligne de véhicule :

### 2.1 Description du système

### 2.2 Cahier de charges

Véhicule destiné à la vente

Catalogue

Options

Panier / gestion de commandes

## Chapitre 3 Introduction aux patterns de construction

### 3.1 Présentation

Leur but est d’abstraire les mécanismes de création d’objet

Il favorise l’utilisation d’interface pour gérer la relation entre objet

### 3.2 Problème

En c# une instruction de création de classe :

```csharp

var objet = new MyClass() ; // creation d’une instance de classe MyClass

```

Dans certains cas il est nécessaire de paramétrer la construction d’objets :

```csharp

public class Document

{

               public string title {get ;set;}

               public string Content {get; set;}

               public string Author {get;set;}

               public DateTime Created {get; set;}

}



```csharp
public class Program {
    public Document CreateDoc(string typeDoc)
    {
        Document doc = null;

        if (typeDoc == "Word")
        {
            doc = new Document();
            doc.Title = "New Document";
            doc.Content = "Content";
        }
        else if (typeDoc == "Excel")
        {
            doc = new Document();
            doc.Title = "New Excel Document";
            doc.Content = "Excel Content";
        }
        else
        {
            doc = new Document();
            doc.Title = "New Document";
            doc.Content = "Content";
        }
    }
}
```

## Chapitre 4

### 4.1 description

Le but du pattern est ma création d'objet regroupé en familles sans devoir connaitre les classes concrètes destinées à la création de ces objets


Une signature de méthode est sont type, son nom, ces paramètre, donc son type d'entrer et type de retour, grâce à sa on sais ce que la méthode a besoin d'avoir a l'entrer et ce quelle nous ressort

```csharp
public void DoSomething() // Sa c'est la signature
```




## Exo AbstractionFactory


Lorsqu'on implémente une interface il faut obligatoirement avoir un comportement donnant (donc par exemple si on appel une interface avec 2 membre il faut obligatoirement utilisé les deux)



## Chapitre 5 Le pattern builder

### 5.1 Description

objectif du program.cs : 
 - avoir un objet builder qui est capable de construire des liasse de doc, une liasse de doc html ou pdf




### Classe Abstraite

- Une **classe abstraite** est une classe qui sert de **modèle** ou de **plan** pour d'autres classes.
- Elle **ne peut pas être instanciée** directement (vous ne pouvez pas créer d'objet à partir d'elle).
- Elle contient des **méthodes abstraites** (méthodes sans corps, juste leur signature), que les classes qui héritent d'elle doivent obligatoirement implémenter.
- Une classe abstraite peut aussi contenir des méthodes **concrètes** (déjà implémentées) et des attributs.

### Classe Concrète

- Une **classe concrète** est une classe normale que vous pouvez **instancier** (créer des objets à partir d'elle).
- Elle fournit une implémentation complète pour toutes ses méthodes.
- Une classe concrète peut hériter d'une classe abstraite et doit alors implémenter toutes les méthodes abstraites de la classe parente.



Composition : Mécanisme qui permet a une classe de contenir une instance de cette même classe d'une autre




## Chapitre 7 

### 7.1 Description

- Création de nouveaux objets par duplication d'objets existants
- On les appelle Prototype
- Capacité de clonage



![[Pasted image 20241231092233.png]]


### 7.4 Domaine d'utilisation

- Le design pattern prototype permet de créer des copies d'objets existant sans rendre le code dépendant de leur classes concrètes. Au lieu de créer un objet a partir de zéro, on clone un objet existant (le prototype) et on le modifie si besoin.
- C'est comme faire une photocopie d'un document : on copie l'original et on peut modifier la copie
- L'avantage principale est la création d'objet complexe simplifiées.

- Cas d'usage :
    - Objets avec de nombreuses configuration (éditeur graphique : forme géométriques)
    - En jeux vidéos, création d'ennemis et leur variable en grande quantité
    - Création d'une configuration par défaut dans un jeu/logiciel (permet de restaurer le défaut rapidement et de configurer a nouveau)
    - Pour éviter la création d'objets systèmes couteux ; connexion réseaux, ressources partagées ....


## Chapitre 8 Le pattern Singleton

### 8.1 Description :

- Le pattern Singleton permet d'assurer qu'une classe ne possède qu'une seule instance au cours de l'exécution du programme
- Une méthode de classe unique qui retourne cette instance



## Chapitre 9 Introduction aux pattners de structuration

### 9.1 Présentation

- L'objectif est de facilité l'indépendance de l'interface d'un objet vis a vie de son implémentation. Dans le cas d'un ensemble d'objets, il s'agit aussi de rendre cette interface indépendante de la hiérarchie des classes et de la composition des objets.
- Les patterns de structuration encapsulent la composition des objets (augmentation du niveau d'abstraction)
- Précédemment les patterns de création encapsulaient la création des objets.


## Chapitre 10
### 10.1 Description

- Convertir l'interface d'une classe existante en une interface attendu

### 10.2 Exemple

![[Pasted image 20241231110336.png]]


### Adapter

#### Les participants :
- "Interface" : introduit la signature des methodes que l'objet "Adapter" doit implementer
- Client : interagit avec les objets implementant l'interface "Interface"
- Adapter : adapte l'interface pour que l'objet puisse etre utilisé par le client
- Adapte : introduit les methodes dont l'interface doit être adaptee pour correspondre a "Interface".

