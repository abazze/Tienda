1. ¿C# permite herencia múltiple?
  No, c# no permite herencia múltiple, en su lugar se permite la implementación de múltiples interfaces

2. ¿Cuándo utilizaríauna clase abstracta en lugar de una interfaz? Ejemplifique.
  Usaría una clase abstracta cuando se trate de una jerarquía de clases en una relación de herencia y una interfaz cuando se trate de clases que no están relacionadas.
  Por ejemplo si tengo que implementar un método Calcular y este método calcula el precio de un local o un piso usaría una clase abstracta Inmueble y en el colocaría el método para que sus clases descendientes lo sobrescriban. Ahora si el método Calcular lo usa una clase calculadora, una clase sistema y una clase cajaRegistradora usaría una interfaz ya que estas clases no están relacionadas.

3. ¿Qué implica una relación de generalización entre dos clases?
  Una generalización implica una relación de herencia entre esas clases, pudiendo así la clase descendiente acceder a los atributos y métodos de su superclase e incluso rescribir dichos métodos si fuera necesario.

4. ¿Qué implica una relación de implementación entre una clase y una interfaz?
  Una implementación entre una clase y una interfaz es como un contrato en el que cada clase que implemente a la interfaz deberá sí o sí sobrescribir los métodos que se encuentren en dicha interfaz.

5. ¿Qué diferencia hay entre la relación de composición y la agregación?
  En una composición existe una fuerte relación entre las clases, al crearse una clase se crea la otra y al destruírse esa clase también se destruye la otra, es decir, una clase no puede existir sin la otra. Por ejemplo una escuela con aulas, es una relación de composición ya que si se destruye la escuela las aulas no pueden existir.
  En cambio en una agregación la relación entre las clases es más débil, una clase puede existir independientemente de que la otra clase exista. Siguiendo con el ejemplo de la escuela podemos tomar como agregación la relación entre las aulas y los alumnos, los alumnos pueden existir sin la necesidad de que exista el aula y viceversa.

6. Indique V o F según corresponda. Diferencia entre asociación y agregación:
  a. Una diferencia es que la segunda indica la relación entre un "todo" y sus "partes", mientras que en la primera los objetos están al mismo nivel contextual. V
  b. Una diferencia es que la agregación es la cardinalidad 1 a muchos mientras que la asociación es de 1 a 1. F(la asociación también puede tener cardinalidad de 1 a muchos)
  c. Una diferencia es que, en la agregación, la vida o existencia de los objetos relacionados está fuertemente ligada, es decir que si "muere" el objeto contenedor también morirán las "partes", en cambio en la asociación los objetos viven y existen independientemente de la relación. F(en la agregación también los objetos viven y existen independientemente de la relación)