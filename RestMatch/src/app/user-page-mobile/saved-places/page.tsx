import SavedPlaceCard from "@/components/userpage/saved-places/saved-place-card";

const SavedPlaces = () => {
  return (
    <div className="w-full">
      <div className="w-full pt-3 px-7">
        <h1 className=" mb-5 text-[35px] font-bold">
          My saved places
        </h1>
        <div className="grid grid-cols-1 gap-y-10">
          <SavedPlaceCard />
          <SavedPlaceCard />
          <SavedPlaceCard />
          <SavedPlaceCard />
        </div>
      </div>
    </div>
  );
};

export default SavedPlaces;
