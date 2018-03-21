<html>
<body>
<form method="post">
Ingrese la Fuerza Aplicada:
<input type="number" name="Fuerza" /><br><br>
<input  type="submit" name="submit" value="Calcular">
</form>
<?php
    if(isset($_POST['submit']))
    {
        $Fuerza = $_POST['Fuerza'];
        $Gravedad = 9.8;
        $Peso =  $Fuerza/$Gravedad;
echo "El Peso, cuando se aplica una Fuerza de $Fuerza Newtons y se mantiene una Gravedad de $Gravedad es: ".$Peso." Kg.";
}
?>
</body>
</html>
