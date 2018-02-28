# Understanding Strange IOC with Unity

## Conventions Followed:

1. One Bootstrap file at project root which points to the config file.
2. All context files inside the config folder which contains all the binding configurations.
3. Store all global signals inside Signals folder.
4. For Views, create an individual folder for a view. Inside that create files for mediator and view.
5. Create separate folders for managers and models.

## Communications rules for signals:

1. Views will only dispatch local signals to talk with their respective mediators.
2. Mediators and commands are supposed to be the only ones  who dispatch and listen to signals.
3. Services dispatch signals which are listened to by commands.
4. Models and services should never listen to signals.

## Injection Rules:

1. Mediators should only be injected in corresponding views.
2. Global signals to be injected in mediators, commands and services.
3. Models, managers and services should be injected in commands only.