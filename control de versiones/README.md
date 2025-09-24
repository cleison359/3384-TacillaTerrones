# Control de versiones
### GitBash
- Es una interfaz de línea de comandos para Windows que permite usar comandos de Git y Unix. Facilita el control de versiones usando Git en un entorno similar a Linux.

### GitHub
- Es una plataforma en línea para alojar y colaborar en proyectos que usan Git. Permite guardar repositorios, compartir código y trabajar con otros desarrolladores.

## comandos de configuración
git config --global user.name "Tu Nombre"

git config --global user.email "tu@email.com"

git config --global core.editor "code -wait"

git config --list

## comandos basicos de repositorio
git init # Inicializar repositorio

git status # Ver estado de archivos

git add archivo.txt # Agregar archivo específico

git add . # Agregar todos los archivos

git commit -m "mensaje" # Crear commit con mensaje

git log # Ver historial de commits

git log --oneline # Ver historial resumido


## comandos de repositorio remoto
git remote add origin [URL] # Conectar con repositorio remoto

git remote -v # Ver repositorios remotos

git push origin main # Subir cambios a GitHub

git push -u origin main # Primer push (establecer upstream)

git pull origin main # Descargar cambios de GitHub

git clone [URL] # Clonar repositorio existente


## comandos de información