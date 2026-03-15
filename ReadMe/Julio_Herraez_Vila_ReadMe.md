# Sistema de Partículas con Tiro Parabólico (Unity)

## Descripción

Este proyecto consiste en intentar simular  implementar un **sistema de
partículas básico en Unity. El objetivo del trabajo es simular el comportamiento de varias partículas que se mueven
siguiendo una **trayectoria parabólica**, aplicando las variables del movimiento de proyectiles.

El sistema genera múltiples partículas desde un mismo punto y cada una se mueve de forma independiente teniendo en cuenta 
su velocidad inicial, el ángulo de lanzamiento, gravedad y el tiempo de vida.



## Características

-   Sistema de partículas creado mediante **prefabs**.
-   Movimiento basado en **ecuaciones físicas del tiro parabólico**.
-   Parámetros editables desde el **Inspector de Unity**:
    -   Número de partículas
    -   Velocidad inicial
    -   Ángulo inicial
    -   Tiempo de vida
    -   Gravedad
-   Generación de partículas con **valores aleatorios** para que el
    efecto sea más natural.
-   Eliminación automática de partículas cuando superan su tiempo de
    vida.



## los scripts

### "Particle"

Este script almacena todas las variables que vamos a utilizar de cada partícula,
como: - velocidad inicial - ángulo inicial - gravedad - tiempo de vida -
posición inicial

Tiene que guardar los datos necesarios para calcular el movimiento
de cada partícula.

### "ParticleController"

Este script gestiona todo el sistema de partículas: - Crea las
partículas a partir de un **prefab** - Guarda las partículas en una
lista - Actualiza su posición en cada frame - Elimina las partículas
cuando termina su tiempo de vida

Las partículas se activan **al presionar la tecla Espacio**, generando como una
especie de explosión de partículas.

## Resultado

Al darle al play y presionar **Espacio**, se genera una explosión
de partículas que salen disparadas desde un punto inicial siguiendo
trayectorias parabólicas. Cada partícula tiene un comportamiento
ligeramente diferente gracias a la variación aleatoria de algunos
parámetros, lo que genear también que sea random


## De

Julio Herraez Vila

