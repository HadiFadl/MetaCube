# MetaCube

MetaCube is a tool that can be used to read the SQL Server Analysis Server Objects using AMO assemblies and map each object to the related directory and configuration files located in the server data directory (DataDir property).

You can use the Classes within your own solution or you can use the application as a tool.

---------------------------------------

# SSAS Data directory contents hierarchy

After building many multidimensional Cube using SSAS, i can assume that the following tree is the Data directory hierarchy:

	|- Data Directory
		|- Database (.db)
			|- Dimension (.dim)
			|- Role (.role)
			|- Mining Structure (.dms)
			|- Data Source (.ds)
			|- Data Source View (.dsv)
			|- Multidimensional Cube (.cub)
				|- Measure Group (.det)
					|- Partition (.prt)
					|- AggregationDesign (.agg)


Each object from the tree above can be stored in form of a directory or/and an XML file.

The Actions and Kpis information are stored within the Cube XML configuration file.

*Example:*

- Object: Cube
- Directory: `<DataDir>\<database>\<cube ID>.cub\`
- XML file: `<DataDir>\<database>\<cube ID>.cub.xml`


# Link SSAS AMO objects to data directory files

## Reading data using AMO

To read SSAS object from deployed Analysis Cube, i improved the code of the following project to add more objects and to link them with the relevant directories/files.

- [SSASAMODB](https://github.com/msornakumar/SSASAMODB)


## Updated method

To map every AMO object to the relevant directory/XML file we have to loop over objects starting from top level (database) and retrieve the files/directories found in each level and map it using the <Object>.ID property and the extensions (as mentioned in the tree above)

The following code is written in C# and it is an updated version of the method published in the link above:

**Note that the method only works on local servers or you must have a Mapped network drive with the same letter of the Original drive that contains the data directory. In addition you must have the permission to access the Analysis Server objects**

### Reading meta data

You can simply read the data by passing the server name to the `ReadMeta()` function:

```cs
dataGridView1.DataSource = MetaCube.SSASAMO.ReadMeta(@"Machine\Instance");
```

### SSASObject Class

The `ReadMeta()` function returns a `List<SSASObject>`:


```cs
public class SSASObject
{

    public enum ObjectType{

        Cube = 0,
        MeasureGroup = 1,
        Dimension = 2,
        Partition = 3,
        AggregationDesign = 4,
        MiningStructure = 5,
        Role = 6,
        DataSource = 7,
        DataSourceView = 8,
        Database = 9,
        Server = 10,
        Kpi = 11,
        Action = 12

    }

    public int ID { get; set; } //incremental ID 
    public int? ParentID { get; set; } // Parent incremental ID
    public ObjectType Type { get; set; } // The Object type
    public string ObjectID { get; set; } // Object ID defined in SSAS
    public string ObjectName { get; set; } // Object Name defined in SSAS
    public string Extension { get; set; } // The Object extension
    public string FolderPath { get; set; } // The Object related directory
    public string FolderName { get; set; } // The directory name
    public DateTime? FolderModifiedDate { get; set; } // The directory last modified date
    public string FolderIncremetalID { get; set; } // The Incremental Number mentioned in the directory name
    public string XMLFilePath { get; set; } // The Object related XML file
    public string XMLFileName { get; set; } // The XML file name
    public DateTime? XmlModifiedDate { get; set; } // The XML file last modified date
    public string XmlIncremetalID { get; set; }  // The incremental number mentioned in the XML file name      


}
```

