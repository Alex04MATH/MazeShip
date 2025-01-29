### Introducción
A partir de aquí comienza lo interesante. Su tarea, si decide aceptarla,
consiste en crear un juego multijugador con temática de escape de laberinto. Se le darán varias tareas esenciales que definirán el límite mínimo
de lo que usted debe implementar. A partir de ahí, puede dejar volar su
imaginación para crear un juego  ́unico y personal del cual pueda sentirse
orgulloso.

### Reglas
El juego debe admitir dos o más jugadores por partida. Cada jugador
posee una cantidad x de fichas esparcidas por el laberinto.

### Tablero
En este juego los tableros se generan dinámicamente. Debe implementar un algoritmo tal que, al iniciar una partida, genere un tablero cuadrado de n×n casillas (usted elige el tamaño) con objetos esparcidos aleatoriamente. A continuación, se muestran los posibles objetos básicos que deben implementarse; usted es libre de añadir más:
1. Obstáculos: Impiden el paso de las fichas.
2. Trampas: Aplican alguna penalización a la primera ficha que se mueva a esa casilla.
Tenga en cuenta que el tablero debe ser generado de manera que ninguna casilla sea inalcanzable desde ninguna posición. Además, su juego debe tener al menos tres trampas distintas implementadas.

### Preparación
Debe contar con un conjunto de al menos 5 fichas disponibles para que los jugadores las escojan. Puede decidir si cada jugador puede escoger una o más fichas para sus partidas, pero todos los jugadores deben tener la misma cantidad de fichas. Cada ficha disponible debe tener una habilidad definida y un tiempo de enfriamiento. El tiempo de enfriamiento impide el uso de esa habilidad durante los siguientes turnos. Además, cada ficha tiene una velocidad determinada que indica cuántas casillas puede desplazarse en cada turno. Usted es libre de definir para sus fichas todas sus características (habilidad, enfriamiento y velocidad). Tenga en cuenta que
las fichas no pueden morir permanentemente durante el juego y diseñe sus
habilidades en función de esto. Más adelante se le darán algunos ejemplos
de habilidades que pueden servir de inspiración


### Turnos
En su turno, un jugador debe escoger una de sus fichas y moverla a una casilla válida (sin obstáculo) que esté al alcance de su velocidad. Además, al mover una ficha, puede decidir usar su habilidad o no

### Objetivo del juego
Esto queda también a su disposición. Puede definir una o más casillas como salida y como condición de victoria que el primer jugador en lograr sacar del tablero a todas sus fichas gane, o que el primero en alcanzar cierto punto con cualquiera de sus fichas sea el vencedor. Incluso puede esparcir casillas por el tablero que deban ser visitadas para adquirir algún objeto

### Interfaz visual
Usted es libre de escoger el tipo de interfaz visual con la que se sienta más cómodo. No importa qu ́e herramienta escoja, siempre y cuando haga un buen trabajo con ella. Un proyecto de consola puede obtener 5 puntos sin ninguna limitación, pero debe notarse el esfuerzo por lograr una experiencia user friendly. Con algo tan básico como una consola se pueden crear cosas espectaculares, solo hace falta dedicación. A continuación, se muestran algunas ideas para la interfaz visual:
- Consola: Puede hacer un juego de consola. Existen bibliotecas de clases como Spectre.Console que pueden ayudarlo.
- Interfaz web: Puede utilizar frameworks como Blazor para crear una interfaz que reciba datos de su lógica.
- Unity o Unreal: Si quiere ir un poco más allá, puede aprender a usar Unity o Unreal para crear su juego, ¡incluso un juego tridimensional!
- Uno Platform: Un software multiplataforma muy útil que permite crear aplicaciones enteras sin salir de C#.

### Evaluación
Los requisitos mínimos para aprobar el proyecto ya se mencionaron en este documento. A continuación, se ofrece un resumen:
1. Tablero generado aleatoriamente.
2. Obstáculos.
3. Al menos tres trampas distintas implementadas.
4. Todas las casillas deben ser alcanzables desde cualquier posición.
5. Más de 5 fichas para escoger.
6. Todas las fichas deben tener una habilidad, tiempo de enfriamiento y velocidad.
7. Debe existir una condición de victoria.
8. Debe existir una interfaz visual que permita jugar.
9. El juego debe iniciar, ejecutarse, y detenerse cuando algún jugador

cumpla con la condición de victoria. Una vez implementados los requisitos mínimos, es posible obtener la
nota mínima. Si desea ir más allá, puede aánadir a su proyecto cualquier cosa que se le ocurra, siempre y cuando no entre en conflicto con los requisitos básicos. A continuación, se muestran algunas ideas:
1. Interfaz visual bien trabajada y agradable de jugar.
2. Jugador virtual: puede implementar una inteligencia artificial que juegue por su cuenta.
3. Variedad de fichas y trampas.
4. Algoritmo inteligente de generaci  ́on de tablero, con coherencia. Trampas inevitables en pasillos, laberintos grandes y difíciles de descifrar, posiciones iniciales estratégicas de las fichas.
5. Casillas con beneficios y ayudas que las fichas pueden utilizar.
6. Armas que las fichas puedan recoger.
7. Portales de teletransportación.
8. Fichas NPC que obstaculicen a los jugadores.