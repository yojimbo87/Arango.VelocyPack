# velocypack.net

Velocypack.net is C# implementation of the [velocypack](https://github.com/arangodb/velocypack) compact serialization format.

## Implementation status

Below is a table which consists of implementation progress for three main parts of velocypack format processing. Each part is responsible for specific functionality:
- **parsing** - slicing of raw binary data into segments based on value types
- **deserialization** - transformation of segments into C# objects
- **serialization** - transformation of C# objects into segments and raw binary data

| Value type                     | Parsing | Deserialization | Serialization |
|--------------------------------|:-------:|:---------------:|:-------------:|
| None                           |         |                 |               |
| EmptyArray                     | DONE    |                 |               |
| OneByteNonIndexedArray         | DONE    |                 |               |
| TwoByteNonIndexedArray         | DONE    |                 |               |
| FourByteNonIndexedArray        | DONE    |                 |               |
| EightByteNonIndexedArray       | DONE    |                 |               |
| OneByteIndexedArray            |         |                 |               |
| TwoByteIndexedArray            |         |                 |               |
| FourByteIndexedArray           |         |                 |               |
| EightByteIndexedArray          |         |                 |               |
| EmptyObject                    | DONE    |                 |               |
| OneByteIndexedSortedObject     |         |                 |               |
| TwoByteIndexedSortedObject     |         |                 |               |
| FourByteIndexedSortedObject    |         |                 |               |
| EightByteIndexedSortedObject   |         |                 |               |
| Unused                         |         |                 |               |
| CompactNonIndexedArray         | DONE    |                 |               |
| CompactNonIndexedObject        |         |                 |               |
| Reserved                       |         |                 |               |
| Illegal                        |         |                 |               |
| Null                           |         |                 |               |
| False                          | DONE    |                 |               |
| True                           | DONE    |                 |               |
| Double                         |         |                 |               |
| UnixTimestamp                  |         |                 |               |
| External                       |         |                 |               |
| MinKey                         |         |                 |               |
| MaxKey                         |         |                 |               |
| OneByteInt                     |         |                 |               |
| TwoByteInt                     |         |                 |               |
| ThreeByteInt                   |         |                 |               |
| FourByteInt                    |         |                 |               |
| FiveByteInt                    |         |                 |               |
| SixByteInt                     |         |                 |               |
| SevenByteInt                   |         |                 |               |
| EightByteInt                   |         |                 |               |
| OneByteUInt                    |         |                 |               |
| TwoByteUInt                    |         |                 |               |
| ThreeByteUInt                  |         |                 |               |
| FourByteUInt                   |         |                 |               |
| FiveByteUInt                   |         |                 |               |
| SixByteUInt                    |         |                 |               |
| SevenByteUInt                  |         |                 |               |
| EightByteUInt                  |         |                 |               |
| ZeroInt                        | DONE    |                 |               |
| PosOneInt                      | DONE    |                 |               |
| PosTwoInt                      | DONE    |                 |               |
| PosThreeInt                    | DONE    |                 |               |
| PosFourInt                     | DONE    |                 |               |
| PosFiveInt                     | DONE    |                 |               |
| PosSixInt                      | DONE    |                 |               |
| PosSevenInt                    | DONE    |                 |               |
| PosEightInt                    | DONE    |                 |               |
| PosNineInt                     | DONE    |                 |               |
| NegSixInt                      | DONE    |                 |               |
| NegFiveInt                     | DONE    |                 |               |
| NegFourInt                     | DONE    |                 |               |
| NegThreeInt                    | DONE    |                 |               |
| NegTwoInt                      | DONE    |                 |               |
| NegOneInt                      | DONE    |                 |               |
| EmptyString                    |         |                 |               |
| ShortString                    |         |                 |               |
| LongString                     |         |                 |               |
| Blob                           |         |                 |               |
| PosFloat                       |         |                 |               |
| NegFloat                       |         |                 |               |
| Custom                         |         |                 |               |

