# MumbleLink-CSharp-GW2
Specialized MumbleLink library for use with GuildWars 2

##Example Usage 

```
var link = new GW2Link();//No parameters needed
MumbleLinkedMemory data = link.Read();//We got the default MumbleLink Struct, useful for position/rotation
GW2Context = link.GetContext();//We're extracting the Context field from the default MumbleLink Struct for easy usage (contains : MapId, MapType, ShardId, Instance and Build)
Coordinates = link.GetCoordinates();//Get Coordinates converted to Meters, GW2 writes them in inches into the Mumble Link API
link.Dispose(): //To free the resources
```

The Identity field from the `MumbleLinkedMemory` struct is standard JSON, I might add a convenience method to parse it in some time
