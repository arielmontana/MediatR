# MediatR
Ejemplo de utilización de MediatR a través de CQRS.
Aplicando Behaviors para validadores
La idea de este ejemplo es muy simple, se trata de empezara aplicar CQRS usando como comunicador de mensajes MediatR.
Inicialmente lo usarmos para ejecutar la lógica de los handlers de manera genérica aprovechando la potencia del injector de dependencia y el service locator.
Luego aprovechamos los pipelines de MediatR para inyectar comportamientos "Behaviors"
