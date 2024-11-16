import SavedPlaceCard from "@/components/userpage/saved-places/saved-place-card";

const SavedPlaces = () => {
  return (
    <div className="w-full">
      <div className="w-full pt-16 px-7">
        <h1 className="px-[3.25rem] mb-5">My saved places</h1>
        <div className="grid grid-cols-3 gap-y-10">
          <SavedPlaceCard />
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
