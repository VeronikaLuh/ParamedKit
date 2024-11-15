import PillButton from "@/components/common/PillButton";
import { imageUrl } from "@/utils/constants";
import classes from "./page.module.scss";

const Preferences = () => {
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

  return (
    <div className="py-11">
      <img
        className="float-right h-[400px]"
        src={`${imageUrl}/preferences/cookie.png`}
      />
      <div className="px-14">
        <h1 className="pb-8">WELCOME!</h1>
        <h2 className="font-bold pb-[6rem]">Choose your preferences:</h2>
        <div>
          <div className="pb-12">
            <h4 className="font-bold pb-6">
              I usually like to eat: (minimum 1 option)
            </h4>
            <div className="flex flex-wrap justify-center gap-6">
              {foodOptions.map((food) => (
                <PillButton>{food}</PillButton>
              ))}
            </div>
          </div>
          <div className="pb-12">
            <h4 className="font-bold pb-6">
              On avarage, I want to spend on food: (minimum 1 option)
            </h4>
            <div className="flex flex-wrap justify-center gap-6">
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
          <div className="pb-2">
            <h4 className="font-bold pb-6">
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
        <div className="flex justify-end">
          <button className="px-6 py-3 text-2xl font-bold rounded-lg bg-[#876542] hover:bg-[#805e3f] active:bg-[#755439]">
            Next
          </button>
        </div>
      </div>
    </div>
  );
};

export default Preferences;
