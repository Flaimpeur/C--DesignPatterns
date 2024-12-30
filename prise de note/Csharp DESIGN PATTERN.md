
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


