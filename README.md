Taller Formativo: Mejores Prácticas y Patrones de Diseño

Este taller tiene como objetivo la mejora y refactorización de una aplicación existente, 
aplicando mejores prácticas, principios SOLID y patrones de diseño para abordar requerimientos funcionales específicos y anticipar futuras expansiones.

Escenario del Problema
Se requiere completar funcionalidades en un aplicativo de automóviles. El desafío principal radica en que la implementación actual presenta inconvenientes y es necesaria una solución robusta y escalable.

Los requisitos funcionales son los siguientes:

Funcionalidad de Agregar Vehículos: Implementar los métodos add Mustang y add Explorer en el Home Page. El patrón repositorio existente para operaciones CRUD no funciona como se espera y necesita ser corregido.

Independencia de la Base de Datos: Dada la inmadurez del esquema de la base de datos, es necesario probar la funcionalidad de agregar vehículos sin persistencia en la base de datos. Esto permitirá la integración con la base de datos una vez que esté lista.

Propiedades por Defecto para Vehículos: Se debe agregar el año actual y 20 propiedades más por defecto a los vehículos, las cuales se especificarán en un sprint futuro. El diseño debe minimizar los cambios futuros al incorporar estas propiedades.

Adición de Nuevos Modelos (Factory Method): Se planea introducir un nuevo modelo de vehículo (Color: Red, Marca: Ford, Modelo: Escape). Se sugiere la implementación de un Factory Method para facilitar la adición de futuros modelos.
