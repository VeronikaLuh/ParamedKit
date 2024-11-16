import PillButton from "@/components/common/PillButton";
import classes from "../../preferences/page.module.scss";

const SavedPreferences = () => {
  const foodOptions = [
    "Italian Cuisine",
    "Chinese Cuisine",
    "Mexican Cuisine",
    "Japanese Cuisine",
    "Indian Cuisine",
    "French Cuisine",
    "Mediterranean Cuisine",
    "American Cuisine",
    "Greek Cuisine",
    "Ukrainian Cuisine",
  ];

  const costOptions = [50, 150, 300, 500, 800, 1000];

  const locationOptions = ["Lviv", "Kyiv", "Odesa"];

  const groupOptions = (options: string[]): string[][] => {
    return options.reduce<string[][]>((acc, food, index) => {
      const isOddRow = acc.length % 2 === 0;
      const maxItems = isOddRow ? 2 : 3;

      if (!acc.length || acc[acc.length - 1].length === maxItems) {
        acc.push([]);
      }

      acc[acc.length - 1].push(food);
      return acc;
    }, []);
  };

  const groupedOptions = groupOptions(foodOptions);

  return (
    <div className="w-full flex flex-col items-end">
      <div className="px-5 pt-14 w-fit self-start">
        <h1 className="pl-[0.82rem] mb-14">Choose your new preferences:</h1>
        <div>
          <div className="pb-12">
            <h4 className="font-bold pb-6 pl-[0.82rem]">
              I usually like to eat: (minimum 1 option)
            </h4>
            <div className="w-full">
            <div className="flex flex-col items-center w-fit gap-7">
              {groupedOptions.map((group, rowIndex) => (
                <div key={rowIndex} className="flex gap-28">
                  {group.map((food) => (
                    <PillButton key={food}>{food}</PillButton>
                  ))}
                </div>
              ))}
            </div>
            </div>
          </div>
          <div className="pb-12">
            <h4 className="font-bold pb-6 pl-[0.82rem]">
              On avarage, I want to spend on food: (minimum 1 option)
            </h4>
            <div className="w-full">
            <div className="flex flex-wrap w-fit justify-center gap-12">
              {costOptions.slice(0, -1).map((lowerCost, i) => (
                <PillButton>
                  <p>
                    {lowerCost.toString()} - {costOptions[i + 1].toString()} ₴
                  </p>
                </PillButton>
              ))}
              {costOptions.length != 0 && (
                <PillButton>
                  <p>{costOptions[costOptions.length - 1].toString()}+ ₴</p>
                </PillButton>
              )}
            </div>
            </div> 
          </div>
          <div className="pb-2">
            <h4 className="font-bold pb-6 pl-[0.82rem]">
              I usually like to eat: (minimum 1 option)
            </h4>
            <div className={classes["custom-select"] + " w-[11rem]"}>
              <select defaultValue="">
                <option key="" value="" disabled>
                  Location
                </option>
                {locationOptions.map((loc, i) => (
                  <option key={i} value={i}>
                    {loc}
                  </option>
                ))}
              </select>
            </div>
          </div>
        </div>
      </div>
      <div className="pr-40 mb-7">
      <button className="w-64 h-14 bg-[#F0BB81] rounded-[20px] text-[#5D462D] text-[2rem] font-bold">
            Change info
          </button>
          </div>
    </div>
  );
};

export default SavedPreferences;
