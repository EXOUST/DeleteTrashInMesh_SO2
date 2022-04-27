Console.WriteLine("Paste path: ");
string path = Console.ReadLine();
if (String.IsNullOrEmpty(path))
{
    Console.WriteLine("Path is null");
    Console.ReadLine();
    return;
}

Console.WriteLine("enable debugging?");
bool debug = Console.ReadLine() == "true";


List<string> filesToDelete = new List<string>
{
    @"*BL_Brick_*.meta", @"*BL_Brick*.meta", @"*BL_Conc_*.meta", @"*BL_Conc*.meta", @"*BL_Concr_*.meta", @"*BL_Concrete*.meta", @"*BL_Glass*.meta", @"*BL_Grou*.meta",
    @"*BL_Ground*.meta", @"*BL_Metal*.meta", @"*BL_MetalGr*.meta", @"*BL_MetalSol*.meta", @"*BL_MetalThin*.meta", @"*BL_ThinWood*.meta",
    @"*BL_S_Metal*.meta", @"*BL_T_Metal*.meta", @"*BL_Th_Metal*.meta", @"*BL_Th_Wood*.meta", @"*BL_T_Wood*.meta", @"*BL_Wood*.meta",
    @"*BL_SolMetal*.meta", @"*BOX_*.meta", @"*Box0*.meta", @"*Brick_BL_*.meta", @"*Concr_BL_*.meta", @"*Glass_BL_*.meta", @"*Glass_BL_*.meta", @"*Grass_BL_*.meta",
    @"*Gravel_BL_*.meta", @"*Ground_BL_*.meta", @"*LOD1*.meta", @"*LOD2*.meta", @"*LOD3*.meta", @"*LOD4*.meta", @"*LOD_1*.meta", @"*LOD_2*.meta", @"*LOD_3*.meta", @"*LOD_4*.meta", @"*MESH_*.meta", @"*Object0*.meta",
    @"*Object1*.meta", @"*Object2*.meta", @"*Object3*.meta", @"*Object4*.meta", @"*Object5*.meta", @"*Object6*.meta", @"*Object7*.meta",
    @"*Paper_BL*.meta", @"*pb_Mesh*.meta", @"*Sticker1*.meta", @"*Sticker2*.meta", @"*Sticker3*.meta", @"*Sticker4*.meta", @"*Thin_Metal_BL*.meta", @"*Metal_BL_*.meta",
    @"*Thin_Wood_BL*.meta", @"*Wood_BL*.meta",  @"*sand_C_*.meta",

    @"*BL_Brick_*.asset", @"*BL_Brick*.asset", @"*BL_Conc_*.asset", @"*BL_Conc*.asset", @"*BL_Concr_*.asset", @"*BL_Concrete*.asset", @"*BL_Glass*.asset", @"*BL_Grou*.asset",
    @"*BL_Ground*.asset", @"*BL_Metal*.asset", @"*BL_MetalGr*.asset", @"*BL_MetalSol*.asset", @"*BL_MetalThin*.asset", @"*BL_ThinWood*.asset",
    @"*BL_S_Metal*.asset", @"*BL_T_Metal*.asset", @"*BL_Th_Metal*.asset", @"*BL_Th_Wood*.asset", @"*BL_T_Wood*.asset", @"*BL_Wood*.asset",
    @"*BL_SolMetal*.asset", @"*BOX_*.asset", @"*Box0*.asset", @"*Brick_BL_*.asset", @"*Concr_BL_*.asset", @"*Glass_BL_*.asset", @"*Glass_BL_*.asset", @"*Grass_BL_*.asset",
    @"*Gravel_BL_*.asset", @"*Ground_BL_*.asset", @"*LOD1*.asset", @"*LOD2*.asset", @"*LOD3*.asset", @"*LOD4*.asset", @"*LOD_1*.asset", @"*LOD2_*.asset", @"*LOD_3*.asset", @"*LOD_4*.asset", @"*MESH_*.asset", @"*Object0*.asset",
    @"*Object1*.asset", @"*Object2*.asset", @"*Object3*.asset", @"*Object4*.asset", @"*Object5*.asset", @"*Object6*.asset", @"*Object7*.asset",
    @"*Paper_BL*.asset", @"*pb_Mesh*.asset", @"*Sticker1*.asset", @"*Sticker2*.asset", @"*Sticker3*.asset", @"*Sticker4*.asset", @"*Thin_Metal_BL*.asset", @"*Metal_BL_*.asset",
    @"*Thin_Wood_BL*.asset", @"*Wood_BL*.asset", @"*sand_C_*.asset",

    @"*BL_Brick_*.fbx", @"*BL_Brick*.fbx", @"*BL_Conc_*.fbx", @"*BL_Conc*.fbx", @"*BL_Concr_*.fbx", @"*BL_Concrete*.fbx", @"*BL_Glass*.fbx", @"*BL_Grou*.fbx",
    @"*BL_Ground*.fbx", @"*BL_Metal*.fbx", @"*BL_MetalGr*.fbx", @"*BL_MetalSol*.fbx", @"*BL_MetalThin*.fbx", @"*BL_ThinWood*.fbx",
    @"*BL_S_Metal*.fbx", @"*BL_T_Metal*.fbx", @"*BL_Th_Metal*.fbx", @"*BL_Th_Wood*.fbx", @"*BL_T_Wood*.fbx", @"*BL_Wood*.fbx",
    @"*BL_SolMetal*.fbx", @"*BOX_*.fbx", @"*Box0*.fbx", @"*Brick_BL_*.fbx", @"*Concr_BL_*.fbx", @"*Glass_BL_*.fbx", @"*Glass_BL_*.fbx", @"*Grass_BL_*.fbx",
    @"*Gravel_BL_*.fbx", @"*Ground_BL_*.fbx", @"*LOD1*.fbx", @"*LOD2*.fbx", @"*LOD3*.fbx", @"*LOD4*.fbx", @"*LOD_1*.fbx", @"*LOD2_*.fbx", @"*LOD_3*.fbx", @"*LOD_4*.fbx", @"*MESH_*.fbx", @"*Object0*.fbx",
    @"*Object1*.fbx", @"*Object2*.fbx", @"*Object3*.fbx", @"*Object4*.fbx", @"*Object5*.fbx", @"*Object6*.fbx", @"*Object7*.fbx",
    @"*Paper_BL*.fbx", @"*pb_Mesh*.fbx", @"*Sticker1*.fbx", @"*Sticker2*.fbx", @"*Sticker3*.fbx", @"*Sticker4*.fbx", @"*Thin_Metal_BL*.fbx", @"*Metal_BL_*.fbx",
    @"*Thin_Wood_BL*.fbx", @"*Wood_BL*.fbx", @"*sand_C_*.fbx"
};

foreach (string fileDel in filesToDelete)
{
    string[] fileList = System.IO.Directory.GetFiles(path, fileDel);
    foreach (string file in fileList)
    {
        if (debug) Console.WriteLine(file + " will be deleted");

        try
        {
            System.IO.File.Delete(file);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
Console.WriteLine("Done! VK: vk.com/exousted");
Console.ReadLine();