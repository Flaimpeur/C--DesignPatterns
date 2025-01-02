
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

- Convertir l'interface d'une classe existante en une interface attendu par ses clients (afin qu'ils puissent travailler ensemble)
- Autrement dit c'est fournir une nouvelle interface pour répondre aux besoin de clients.

### 10.2 Exemple

![[Pasted image 20241231110336.png]]


### Adapter

#### Les participants :
- "Interface" : introduit la signature des methodes que l'objet "Adapter" doit implementer
- Client : interagit avec les objets implementant l'interface "Interface"
- Adapter : adapte l'interface pour que l'objet puisse etre utilisé par le client
- Adapte : introduit les methodes dont l'interface doit être adaptee pour correspondre a "Interface".



## Chapitre 11 Le pattern Bridge

### 11.1 Description

- Séparer l'aspect d'implémentation d'un objet de son aspect représentation et d'interface

### Exemple 

- Le pattern Bridge sépare une grosse classe en deux parties qui peuvent être développées indépendamment.

- Exemple avec une télécommande TV :
	- Abstraction : La télécommande (les boutons volumes, chaines, ect)
	- Implémentation: Les marques de TV (Sony, samsung, ect)

```java
// Implementation
interface TV{
	void MonterLeSon();
}
// Abstraction
class Telecommande{
	protected TV tv; // Le pont vers l'implementation

	public void MonterLeVolume(){
		tv.MonterLeSon();
	}
}

class TVSony implements TV{
	public void MonterLeSon(){
		System.out.println("Sony: Monter le son");
	}
}

class TVSamsung implements TV {
	public void MonterLeSon(){
		System.out.println("Samsung: Monter le son");
	}
}
```

Avantage :
- On peut changer la marque de la TV sans changer la télécommande
- On peut modifier la télécommande sans toucher au code des TVs
- On peut ajouter de nouvelles marques de TV

C'est comme si on avait une prise universelle qui fonctionne avec différentes prises électriques, l'interface est la même, mais l'implémentation est différentes selon le pays.

### Schema UML

![[Pasted image 20241231152914.png]]

### Schema générique

![[Pasted image 20241231154440.png]]



## Chapitre 13 Le pattern Decorator

### 13.1 Description


- Le but du pattern est d'ajouter dynamiquement des fonctionnalités supplémentaires à un objet
- Aucune modification de l'interface de l'objet
- Transparent vis-à-vis des clients
- Une alternative à la création d'une sous-classe pour enrichir un objet.


#### Ma compréhension de la question

![[Pasted image 20241231161703.png]]


#### Correction 

![[Pasted image 20250102092736.png]]


### 13.4 Domaines d'application

![[Pasted image 20250102093900.png]]

- Ajout dynamique de fonctionnalités
	- Idéal pour les systèmes nécessitant l'ajout de fonctionnalités à un objet sans modification son interface, préservant ainsi la compatibilité avec les clients existants. Cette approche permet une extension transparente des capacités de l'objet.
- Gestion dynamique des fonctionnalités
	- Parfaitement adapté aux systèmes nécessitant la possibilité de retirer des fonctionnalités de manière dynamique. Cette flexibilité permet une adaptation en temps réel aux besoins changeants du système.
- Alternative à l'Héritage Complexe
	- Solution élégante lorsque l'extension par héritage devient impraticable, particulièrement dans les cas où la hiérarchie des classes est déjà complexe. Le pattern offre une approche plus flexible et maintenant que l'héritage traditionnel.


## Chapitre 17 Introduction au patterns de comportement


### 17.1 Description

- Objectif : fournir des solutions pour distribuer les traitements et les algorithmes entre les objets.


## Chapitre 18 Le pattern Chain of Responsibility

### 18.1 Description
- Construit une chaine d'objets telle que si un objet de la chaine ne peut pas répondre à la requête, il puisse la transmettre à son successeur jusqu'à ce que l'un des objets répondent.
![[Pasted image 20250102095859.png]]


### 18.2 Exemple

- Catalogue de véhicule 
- Description de véhicule
- Liaison d'objet en allant du plus spécifique (véhicule) au moins spécifique (description par défaut)

### 18.4 Domaines d'application

- Une chaine d'objet doit gérer une requête selon un ordre défini dynamiquement
- La façon dont une chaine d'objets gère une requête ne doit pas être connue par ses clients.


## Chapitre 19 Command pattern

### 19.1 Description

- Command permet de transformer une requête en un objet, ce qui facilite les opérations comme les annulations ou les "retour en arrière", ou encore les mises en file d'attente des demandes et leur suivi.


membre concret : Method avec plus qu'une signature