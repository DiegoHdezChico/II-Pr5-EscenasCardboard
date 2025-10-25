# Interfaces Inteligentes. Práctica 5. Escenas Cardboard.

### Ejercicio 1.
Para poder cumplir con este ejercicio, hemos seguido los pasos establecidos por el tutorial de [Cardboard SDK](https://developers.google.com/cardboard/develop/unity/quickstart?hl=es-419) y hemos generado una **apk** que luego hemos ejecutado en el teléfono móvil.

![](gifs/Ejercicio1.gif)

---

### Ejercicio 2.
Durante la realización de este segundo apartado hemos llevado a cabo diferentes tareas. La primera de todas ellas ha sido crear la escena desde donde tendrá lugar la acción. Esta labor ha incluido también la creación de un **objeto vacío** que tiene como hijo una cámara con el componente `Tracked Pose Driver` que a su vez contiene como hijo un **prefab** `CardboardReticlePointer` que hemos obtenido de la escena de ejemplo.

Una vez hecho esto hemos trabajado en los siguientes apartados.

#### Creación de un script para mover al jugador.
Para poder mover al jugador por la escena, primero ha sido necesario crear un asset de tipo `Input Actions`. Seguidamente, se ha configurado dicho asset para que responda retornando un `Vector2` al movimiento que detecta desde el joystick izquierdo del mando. Una vez configurado este asset especial, se ha **generado un [script](scripts/Control.cs) con una clase en C# a partir del mismo**. Después de esto, hemos creado [este otro script](scripts/ControladorJugador.cs) para mover a nuestro jugador.


#### Configuración de los objetos recolectables.
Para este apartado, hemos tomado todos los asset de calabazas que habíamos colocado por la escena, los hemos agregado a la capa `Interactive` y les hemos enlazado un [script para que miren al lugar de aparición del jugador](scripts/MirarJugador.cs) y [otro para que se desactiven cuando el jugador los observa directamente](scripts/CustomObjectController.cs). Además, en este segundo script se lanza un evento que alerta a un marcador que muestra cuántas calabazas se han recogido. Sin embargo, parece que los elementos del `Canvas` no son visibles desde las gafas.

![](gifs/Ejercicio2.gif)

---

### Ejercicio 3.
Para este último ejercicio, hemos creado un nuevo [script](scripts/AtraeRecolectables.cs) que, en este caso, se encarga de activar un evento cuando se mira directamente al objeto al que está unido. Por otro lado, también ha sido necesario crear [otro script](scripts/DesplazaObjeto.cs) que moviera las calabazas hasta el espantapájaros.

![](gifs/Ejercicio3.gif)