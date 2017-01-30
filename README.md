# Arango.VelocyPack

Arango.VelocyPack is C# implementation of the [velocypack](https://github.com/arangodb/velocypack) compact serialization format.

## Implementation status

Below is a table which consists of implementation progress for three main parts of velocypack format processing. Each part is responsible for specific functionality:
- **segmentation** - slicing of raw binary data into segments based on value types
- **deserialization** - transformation of segments into C# objects
- **serialization** - transformation of C# objects into segments and raw binary data

| Value type                     | Segmentation | Deserialization | Serialization |
|--------------------------------|:------------:|:---------------:|:-------------:|
| None                           | DONE         | DONE            |               |
| EmptyArray                     | DONE         | DONE            |               |
| OneByteNonIndexedArray         | DONE         | DONE            |               |
| TwoByteNonIndexedArray         | DONE         | DONE            |               |
| FourByteNonIndexedArray        | DONE         | DONE            |               |
| EightByteNonIndexedArray       | DONE         | DONE            |               |
| OneByteIndexedArray            |              |                 |               |
| TwoByteIndexedArray            |              |                 |               |
| FourByteIndexedArray           |              |                 |               |
| EightByteIndexedArray          |              |                 |               |
| EmptyObject                    |              |                 |               |
| OneByteIndexedSortedObject     |              |                 |               |
| TwoByteIndexedSortedObject     |              |                 |               |
| FourByteIndexedSortedObject    |              |                 |               |
| EightByteIndexedSortedObject   |              |                 |               |
| Unused                         | N/A          | N/A             | N/A           |
| CompactNonIndexedArray         | DONE         | DONE            |               |
| CompactNonIndexedObject        |              |                 |               |
| Reserved                       | N/A          | N/A             | N/A           |
| Illegal                        | DONE         | DONE            |               |
| Null                           | DONE         | DONE            |               |
| False                          | DONE         | DONE            |               |
| True                           | DONE         | DONE            |               |
| Double                         | DONE         | DONE            |               |
| UnixTimestamp                  |              |                 |               |
| External                       |              |                 |               |
| MinKey                         | DONE         | DONE            |               |
| MaxKey                         | DONE         | DONE            |               |
| OneByteInt                     | DONE         | DONE            |               |
| TwoByteInt                     | DONE         | DONE            |               |
| ThreeByteInt                   | DONE         | DONE            |               |
| FourByteInt                    | DONE         | DONE            |               |
| FiveByteInt                    | DONE         | DONE            |               |
| SixByteInt                     | DONE         | DONE            |               |
| SevenByteInt                   | DONE         | DONE            |               |
| EightByteInt                   | DONE         | DONE            |               |
| OneByteUInt                    |              |                 |               |
| TwoByteUInt                    |              |                 |               |
| ThreeByteUInt                  |              |                 |               |
| FourByteUInt                   |              |                 |               |
| FiveByteUInt                   |              |                 |               |
| SixByteUInt                    |              |                 |               |
| SevenByteUInt                  |              |                 |               |
| EightByteUInt                  |              |                 |               |
| ZeroInt                        | DONE         | DONE            |               |
| PosOneInt                      | DONE         | DONE            |               |
| PosTwoInt                      | DONE         | DONE            |               |
| PosThreeInt                    | DONE         | DONE            |               |
| PosFourInt                     | DONE         | DONE            |               |
| PosFiveInt                     | DONE         | DONE            |               |
| PosSixInt                      | DONE         | DONE            |               |
| PosSevenInt                    | DONE         | DONE            |               |
| PosEightInt                    | DONE         | DONE            |               |
| PosNineInt                     | DONE         | DONE            |               |
| NegSixInt                      | DONE         | DONE            |               |
| NegFiveInt                     | DONE         | DONE            |               |
| NegFourInt                     | DONE         | DONE            |               |
| NegThreeInt                    | DONE         | DONE            |               |
| NegTwoInt                      | DONE         | DONE            |               |
| NegOneInt                      | DONE         | DONE            |               |
| EmptyString                    |              |                 |               |
| ShortString                    |              |                 |               |
| LongString                     |              |                 |               |
| Blob                           |              |                 |               |
| PosFloat                       |              |                 |               |
| NegFloat                       |              |                 |               |
| Custom                         |              |                 |               |

